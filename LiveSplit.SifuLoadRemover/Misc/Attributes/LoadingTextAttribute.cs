using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.SifuLoadRemover.Misc.Attributes
{
    public class LoadingTextAttribute : Attribute
    {
        public string LoadingText { get; set; }
        public LoadingTextAttribute(string loadingText)
        {
            LoadingText = loadingText;
        }
    }
}
