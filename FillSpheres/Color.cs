using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte red, byte green, byte blue, byte alpha = 255)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public byte GetRed()
        {
            return red;
        }

        public void SetRed(byte newRed)
        {
            red = newRed;
        }

        public byte GetGreen()
        {
            return green;
        }

        public void SetGreen(byte newGreen)
        {
            green = newGreen;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public void SetBlue(byte newBlue)
        {
            blue = newBlue;
        }

        public byte GetAlpha()
        {
            return alpha;
        }

        public void SetAlpha(byte newAlpha)
        {
            alpha = newAlpha;
        }

        public int GetGrey()
        {
            int intRed = Convert.ToInt32(red);
            int intGreen = Convert.ToInt32(green);
            int intBlue = Convert.ToInt32(blue);

            int intGrey = (intRed + intGreen + intBlue) / 3;

            return intGrey;
        }
    }
}