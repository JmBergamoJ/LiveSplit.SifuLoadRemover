using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.SifuLoadRemover.Misc.Attributes
{
    internal class CropOffsetAttribute : Attribute
    {
        public float CropOffsetX { get; set; }
        public CropOffsetAttribute()
        {
            CropOffsetX = -810.0f;
        }

        public CropOffsetAttribute(float cropOffsetX)
        {
            CropOffsetX = Math.Abs(cropOffsetX) * -1;
        }
    }
}
