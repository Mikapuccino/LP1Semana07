using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Sphere
    {
        public Color Color
        {
            get
            {
                byte[] colorValues = new byte[4];
                colorValues[0] = color.GetRed();
                colorValues[1] = color.GetGreen();
                colorValues[2] = color.GetBlue();
                colorValues[3] = color.GetAlpha();
                return colorValues;
            }
        }
        public float Radius { get; set; }

        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            int thrown = 0;
        }

        public void Pop
        {
            set
            {
                radius = 0;
            }
        }

        public void Throw
        {
            set
            {
                if (radius > 0)
                {
                    thrown += 1;
                }
            }
        }

        public int GetTimesThrown => thrown;
    }
}