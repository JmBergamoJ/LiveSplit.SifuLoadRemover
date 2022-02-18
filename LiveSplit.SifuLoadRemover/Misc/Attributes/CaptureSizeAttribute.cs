using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.SifuLoadRemover.Misc.Attributes
{
    internal class CaptureSizeAttribute : Attribute
    {

        private int CaptureSizeX { get; set; }

        public Size Size { get => new Size(CaptureSizeX, 100); }

        public CaptureSizeAttribute()
        {
            CaptureSizeX = 200;
        }
        public CaptureSizeAttribute(int captureSizeX)
        {
            CaptureSizeX = captureSizeX;
        }
    }
}
