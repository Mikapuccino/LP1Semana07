using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private float radius;
        private int thrown;

        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            thrown = 0;
        }

        public byte[] GetColor()
        {   
            byte[] colorValues = new byte[4];
            colorValues[0] = color.GetRed();
            colorValues[1] = color.GetGreen();
            colorValues[2] = color.GetBlue();
            colorValues[3] = color.GetAlpha();
            return colorValues;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                thrown += 1;
            }
        }

        public int GetTimesThrown()
        {
            return thrown;
        }
    }
}