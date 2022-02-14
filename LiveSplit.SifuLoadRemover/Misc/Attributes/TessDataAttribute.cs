using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.SifuLoadRemover.Misc.Attributes
{
    public class TessDataAttribute : Attribute
    {
        public string TessDataName { get; set; }

        public TessDataAttribute(string TessDataName)
        {
            this.TessDataName = TessDataName;
        }
    }
}
