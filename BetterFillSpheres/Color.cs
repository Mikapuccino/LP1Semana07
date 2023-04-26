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

        // Returns the average between all color values
        public int Grey
        {
            get
            {
                int intRed = Convert.ToInt32(Red);
                int intGreen = Convert.ToInt32(Green);
                int intBlue = Convert.ToInt32(Blue);

                int intGrey = (intRed + intGreen + intBlue) / 3;

                return intGrey;
            }
        }
    }
}