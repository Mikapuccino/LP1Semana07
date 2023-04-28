using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Color
    {     
        private string colorName; 
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

        public string Name
        {
            get
            {               
                if ((Red == 255) && (Green == 0) && (Blue == 0))
                {
                    colorName += "1";
                }

                if ((Red == 0) && (Green == 255) && (Blue == 0))
                {
                    colorName += "22";
                }

                if ((Red == 0) && (Green == 0) && (Blue == 255))
                {
                    colorName += "4444";
                }
                
                return colorName switch
                {
                    { Length: 1 } => "Red 100%" ,
                    { Length: 2 } => "Green 100%" ,
                    { Length: 4 } => "Blue 100%" ,
                    _ => "Mixed"
                };
            }
        }
    }
}