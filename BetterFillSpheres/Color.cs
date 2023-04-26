using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; } = 255;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public int Grey
        {
            get
            {
                int intRed = Convert.ToInt32(red);
                int intGreen = Convert.ToInt32(green);
                int intBlue = Convert.ToInt32(blue);

                int intGrey = (intRed + intGreen + intBlue) / 3;

                return intGrey;
            }
        }
    }
}