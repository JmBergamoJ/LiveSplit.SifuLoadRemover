using LiveSplit.Model;
using LiveSplit.SifuLoadRemover.Misc;
using LiveSplit.SifuLoadRemover.Misc.Extensions;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace LiveSplit.SifuLoadRemover.Component
{
    class SifuLoadRemoverComponent : IComponent
    {
        public string ComponentName
        {
            get { return Constants.Component.Name; }
        }
        public GraphicsCache Cache { get; set; }


        public float PaddingBottom { get { return 0; } }
        public float PaddingTop { get { return 0; } }
        public float PaddingLeft { get { return 0; } }
        public float PaddingRight { get { return 0; } }

        public bool Refresh { get; set; }

        public IDictionary<string, Action> ContextMenuControls { get; protected set; }

        public SifuLoadRemoverSettings settings { get; set; }

        private bool isLoading = false;

        private TimerModel timer;
        private bool timerStarted = false;
        private double total_paused_time = 0.0f;

        public enum SifuGameState
        {
            RUNNING,
            LOADING
        }

        private SifuGameState SifuState = SifuGameState.RUNNING;
        private int runningFrames = 0;
        private int pausedFrames = 0;
        private int pausedFramesSegment = 0;
        private string GameName = "";
        private string GameCategory = "";
        private int NumberOfSplits = 0;
        private List<string> SplitNames;
        private DateTime lastTime;

        private DateTime segmentTimeStart;
        private LiveSplitState liveSplitState;
        private double framesSum = 0.0;
        private int framesSumRounded = 0;
        private int framesSinceLastManualSplit = 0;
        private bool LastSplitSkip = false;

        //private HighResolutionTimer.HighResolutionTimer highResTimer;
        private List<int> NumberOfLoadsPerSplit;


        public SifuLoadRemoverComponent(LiveSplitState state)
        {
            GameName = state.Run.GameName;
            GameCategory = state.Run.CategoryName;
            NumberOfSplits = state.Run.Count;
            SplitNames = new List<string>();

            foreach (var split in state.Run)
            {
                SplitNames.Add(split.Name);
            }

            liveSplitState = state;
            NumberOfLoadsPerSplit = new List<int>();
            InitNumberOfLoadsFromState();

            settings = new SifuLoadRemoverSettings(state);
            lastTime = DateTime.Now;
            segmentTimeStart = DateTime.Now;
            timer = new TimerModel { CurrentState = state };
            timer.CurrentState.OnStart += timer_OnStart;
            timer.CurrentState.OnReset += timer_OnReset;
            timer.CurrentState.OnSkipSplit += timer_OnSkipSplit;
            timer.CurrentState.OnSplit += timer_OnSplit;
            timer.CurrentState.OnUndoSplit += timer_OnUndoSplit;
            timer.CurrentState.OnPause += timer_OnPause;
            timer.CurrentState.OnResume += timer_OnResume;


        }

        private void CreateFileIfNotExists(string path, byte[] bytes)
        {
            if (!File.Exists(path))
                File.WriteAllBytes(path, bytes);
        }

        private void timer_OnResume(object sender, EventArgs e)
        {
            timerStarted = true;
        }

        private void timer_OnPause(object sender, EventArgs e)
        {
            timerStarted = false;
        }

        private void InitNumberOfLoadsFromState()
        {
            NumberOfLoadsPerSplit = new List<int>();
            NumberOfLoadsPerSplit.Clear();

            if (liveSplitState == null)
            {
                return;
            }

            foreach (var split in liveSplitState.Run)
            {
                NumberOfLoadsPerSplit.Add(0);
            }

            //Quicker way to prevent OOB on last split as I'm not sure if the index will go over if the run finishes
            NumberOfLoadsPerSplit.Add(99999);
        }

        private int CumulativeNumberOfLoadsForSplitIndex(int splitIndex)
        {
            int numberOfLoads = 0;

            for (int idx = 0; (idx < NumberOfLoadsPerSplit.Count && idx <= splitIndex); idx++)
            {
                numberOfLoads += NumberOfLoadsPerSplit[idx];
            }
            return numberOfLoads;
        }
        int framesSinceLastCheck = 0;
        private void CaptureLoads()
        {
            try
            {


                if (timerStarted)
                {
                    framesSinceLastManualSplit++;
                    framesSinceLastCheck++;
                    lastTime = DateTime.Now;
                    bool wasLoading = isLoading;
                    if (framesSinceLastCheck >= 4) /*Check every 4 frames for performance*/
                    {
                        framesSinceLastCheck = 0;
                        Bitmap capture = settings.CaptureImage();
                        byte[] array;
                        using (var stream = new MemoryStream())
                        {
                            capture.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                            array = stream.ToArray();
                        }

                        try
                        {
                            using (var img = Pix.LoadFromMemory(array))
                            {
                                using (var page = settings.Engine.Process(img))
                                {
                                    var text = page.GetText();
                                    var confidence = page.GetMeanConfidence();
                                    Console.WriteLine("Mean confidence: {0}", page.GetMeanConfidence());

                                    var normalizedText = text.Normalize();
                                    Console.WriteLine("Text (GetText): {0}", normalizedText);
                                    Console.WriteLine($"settings.gameLanguage: {settings.gameLanguage}");
                                    if (confidence > 0.5f)
                                        isLoading = text.ToUpperInvariant().Contains(settings.gameLanguage.LoadingText().ToUpperInvariant());
                                    else if (confidence == 0 && string.IsNullOrEmpty(text) && isLoading) //EMPTY PAGE - NOT LOADING
                                        isLoading = false;
                                    else
                                        isLoading = false;
                                }
                            }

                            Console.WriteLine($"isLoading? {isLoading}");
                        }
                        catch (Exception ex)
                        {
                            isLoading = false;
                            Console.WriteLine("Error: " + ex.ToString());
                            throw ex;
                        }
                    }

                    timer.CurrentState.IsGameTimePaused = isLoading;

                    if (isLoading && !wasLoading)
                    {
                        segmentTimeStart = DateTime.Now;
                    }

                    if (isLoading)
                    {
                        pausedFramesSegment++;
                    }

                    if (wasLoading && !isLoading)
                    {
                        TimeSpan delta = (DateTime.Now - segmentTimeStart);
                        framesSum += delta.TotalSeconds * 60.0f;
                        int framesRounded = Convert.ToInt32(delta.TotalSeconds * 60.0f);
                        framesSumRounded += framesRounded;
                        total_paused_time += delta.TotalSeconds;

                        Console.WriteLine("SEGMENT FRAMES {7}: {0}, fromTime (@60fps) {1}, timeDelta {2}, totalFrames {3}, fromTime(int) {4}, totalFrames(int) {5}, totalPausedTime(double) {6}",
                          pausedFramesSegment, delta.TotalSeconds,
                          delta.TotalSeconds * 60.0f, framesSum, framesRounded, framesSumRounded, total_paused_time, SplitNames[Math.Max(Math.Min(liveSplitState.CurrentSplitIndex, SplitNames.Count - 1), 0)]);
                        pausedFramesSegment = 0;
                    }


                    if (settings.AutoSplitterEnabled && !(settings.AutoSplitterDisableOnSkipUntilSplit && LastSplitSkip))
                    {
                        //This is just so that if the detection is not correct by a single frame, it still only splits if a few successive frames are loading
                        if (isLoading && SifuState == SifuGameState.RUNNING)
                        {
                            pausedFrames++;
                            runningFrames = 0;
                        }
                        else if (!isLoading && SifuState == SifuGameState.LOADING)
                        {
                            runningFrames++;
                            pausedFrames = 0;
                        }

                        if (SifuState == SifuGameState.RUNNING && pausedFrames >= settings.AutoSplitterJitterToleranceFrames)
                        {
                            runningFrames = 0;
                            pausedFrames = 0;
                            //We enter pause.
                            SifuState = SifuGameState.LOADING;
                            if (framesSinceLastManualSplit >= settings.AutoSplitterManualSplitDelayFrames)
                            {
                                NumberOfLoadsPerSplit[liveSplitState.CurrentSplitIndex]++;

                                if (CumulativeNumberOfLoadsForSplitIndex(liveSplitState.CurrentSplitIndex) >= settings.GetCumulativeNumberOfLoadsForSplit(liveSplitState.CurrentSplit.Name))
                                {
                                    timer.Split();
                                }
                            }

                        }
                        else if (SifuState == SifuGameState.LOADING && runningFrames >= settings.AutoSplitterJitterToleranceFrames)
                        {
                            runningFrames = 0;
                            pausedFrames = 0;
                            //We enter runnning.
                            SifuState = SifuGameState.RUNNING;
                        }
                    }


                    //Console.WriteLine("TIME TAKEN FOR DETECTION: {0}", DateTime.Now - lastTime);
                }
            }
            catch (Exception ex)
            {
                isLoading = false;
                Console.WriteLine("Error: " + ex.ToString());
            }
        }

        private void timer_OnUndoSplit(object sender, EventArgs e)
        {
            runningFrames = 0;
            pausedFrames = 0;

            //If we undo a split that already has met the required number of loads, we probably want the number to reset.
            if (NumberOfLoadsPerSplit[liveSplitState.CurrentSplitIndex] >= settings.GetAutoSplitNumberOfLoadsForSplit(liveSplitState.CurrentSplit.Name))
            {
                NumberOfLoadsPerSplit[liveSplitState.CurrentSplitIndex] = 0;
            }

            //Otherwise - we're fine. If it is a split that was skipped earlier, we still keep track of how we're standing.
        }

        private void timer_OnSplit(object sender, EventArgs e)
        {
            runningFrames = 0;
            pausedFrames = 0;
            framesSinceLastManualSplit = 0;
            //If we split, we add all remaining loads to the last split.
            //This means that the autosplitter now starts at 0 loads on the next split.
            //This is just necessary for manual splits, as automatic splits will always have a difference of 0.
            var loadsRequiredTotal = settings.GetCumulativeNumberOfLoadsForSplit(liveSplitState.Run[liveSplitState.CurrentSplitIndex - 1].Name);
            var loadsCurrentTotal = CumulativeNumberOfLoadsForSplitIndex(liveSplitState.CurrentSplitIndex - 1);
            NumberOfLoadsPerSplit[liveSplitState.CurrentSplitIndex - 1] += loadsRequiredTotal - loadsCurrentTotal;

            LastSplitSkip = false;
        }

        private void timer_OnSkipSplit(object sender, EventArgs e)
        {

            runningFrames = 0;
            pausedFrames = 0;

            //We don't need to do anything here - we just keep track of loads per split now.
            LastSplitSkip = true;
        }

        private void timer_OnReset(object sender, TimerPhase value)
        {
            timerStarted = false;
            runningFrames = 0;
            pausedFrames = 0;
            framesSinceLastManualSplit = 0;
            LastSplitSkip = false;

            InitNumberOfLoadsFromState();
            total_paused_time = 0.0f;

        }

        void timer_OnStart(object sender, EventArgs e)
        {
            InitNumberOfLoadsFromState();
            timer.InitializeGameTime();
            runningFrames = 0;
            framesSinceLastManualSplit = 0;
            pausedFrames = 0;
            timerStarted = true;
            total_paused_time = 0.0f;
        }

        private bool SplitsAreDifferent(LiveSplitState newState)
        {
            //If GameName / Category is different
            if (GameName != newState.Run.GameName || GameCategory != newState.Run.CategoryName)
            {
                GameName = newState.Run.GameName;
                GameCategory = newState.Run.CategoryName;
                return true;
            }

            //If number of splits is different
            if (newState.Run.Count != liveSplitState.Run.Count)
            {
                NumberOfSplits = newState.Run.Count;
                return true;
            }

            //Check if any split name is different.
            for (int splitIdx = 0; splitIdx < newState.Run.Count; splitIdx++)
            {
                if (newState.Run[splitIdx].Name != SplitNames[splitIdx])
                {

                    SplitNames = new List<string>();

                    foreach (var split in newState.Run)
                    {
                        SplitNames.Add(split.Name);
                    }

                    return true;
                }

            }



            return false;
        }
       
        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (SplitsAreDifferent(state))
                settings.ChangeAutoSplitSettingsToGameName(GameName, GameCategory);
            liveSplitState = state;

            CaptureLoads();
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {

        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {

        }

        public float VerticalHeight
        {
            get { return 0; }
        }

        public float MinimumWidth
        {
            get { return 0; }
        }

        public float HorizontalWidth
        {
            get { return 0; }
        }

        public float MinimumHeight
        {
            get { return 0; }
        }

        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            return settings.GetSettings(document);
        }

        public System.Windows.Forms.Control GetSettingsControl(LiveSplit.UI.LayoutMode mode)
        {
            return settings;
        }

        public void SetSettings(System.Xml.XmlNode settings)
        {
            this.settings.SetSettings(settings);
        }

        public void RenameComparison(string oldName, string newName)
        {
        }

        public void Dispose()
        {
            timer.CurrentState.OnStart -= timer_OnStart;
            if (settings.Engine != null)
                settings.Engine.Dispose();

        }
    }
}
