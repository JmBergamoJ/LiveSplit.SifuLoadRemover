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
        [Description("English"), TessData("eng"), LoadingText("LOADING"), CropOffset, CaptureSize]
        English,
        [Description("Chinese - Simplified - 简体中文"), TessData("chi_sim"), /*LoadingText("正在读取")*/LoadingText("正在读")]
        ChineseSimplified,
        [Description("Chinese - Traditional - 中国传统的"), TessData("chi_tra"), LoadingText("載入中")]
        ChineseTraditional,
        [Description("French - Français"), TessData("fra"), LoadingText("CHARGEMENT"), CropOffset(750), CaptureSize(250)]
        French,
        [Description("German - Deutsch"), TessData("deu"), LoadingText("LÄDT"), CropOffset(845), CaptureSize(150)]
        German,
        [Description("Italian - Italiano"), TessData("ita"), LoadingText("CARCIAMENTO"), CropOffset(760), CaptureSize(300)]
        Italian,
        [Description("Japanese - 日本"), TessData("jpn"), LoadingText("読み込み中"), CropOffset, CaptureSize(250)]
        Japanese,
        [Description("Korean - 한국인"), TessData("kor"), LoadingText("로딩"), CropOffset(845), CaptureSize(100)]
        Korean,
        [Description("Portuguese - Português"), TessData("por"), LoadingText("CARREGANDO"), CropOffset(755), CaptureSize(350)]
        Portuguese,
        [Description("Russian - русский"), TessData("rus"), LoadingText("ЗАГРУЗКА"), CropOffset(830), CaptureSize(250)]
        Russian,
        [Description("Spanish - Español"), TessData("spa"), LoadingText("CARGANDO"), CropOffset(770), CaptureSize(220)]
        SpanishSpain,
        [Description("Turkish - Türkçe"), TessData("tur"), LoadingText("YÜKLENIYOR"), CropOffset(770), CaptureSize(250)]
        Turkish
    }
}
