using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.SifuLoadRemover.Misc
{
    internal class Constants
    {
        internal static class Component
        {
            public static string Name = "Sifu Load Remover";
            public static string Description = "Automatically detects and removes loads (GameTime) for Sifu.";
            public static string UpdateURL = "https://raw.githubusercontent.com/JmBergamoJ/LiveSplit.SifuLoadRemover/master/";
        }

        public static string TessDataFolderName = "SifuLoadRemover-tessdata";
        public static string TrainedDataFileExtension = ".traineddata";

        internal static class Messages
        {
            public static string DownloadTessData = "Trained Data file for language [{0}] not detected. Download now?";
            public static string DownloadTessDataTitle = "Download trained data";
        }
    }
}
