using LiveSplit.SifuLoadRemover.Misc.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.SifuLoadRemover.Misc.Enums
{
    public enum GameLanguage
    {
        [Description("English"), TessData("eng"), LoadingText("LOADING")]
        English,
        [Description("Chinese - Simplified"), TessData("chi_sim")]
        ChineseSimplified,
        [Description("Chinese - Traditional"), TessData("chi_tra")]
        ChineseTraditional,
        [Description("Dutch"), TessData("nld")]
        Dutch,
        [Description("French"), TessData("eng")]
        French,
        [Description("German"), TessData("deu")]
        German,
        [Description("Italian"), TessData("ita")]
        Italian,
        [Description("Japanese"), TessData("jpn")]
        Japanese,
        [Description("Korean"), TessData("kor")]
        Korean,
        [Description("Polish"), TessData("pol")]
        Polish,
        [Description("Portuguese"), TessData("por")]
        Portuguese,
        [Description("Russian"), TessData("rus")]
        Russian,
        [Description("Spanish - Spain"), TessData("spa")]
        SpanishSpain,
        [Description("Turkish"), TessData("tur")]
        Turkish
    }
}
