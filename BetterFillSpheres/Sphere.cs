using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Sphere
    {
        private int thrown;
        
        public Color Color { get; set; }
        public float Radius { get; set; }

        private int Thrown
        {
            get
            {
                return thrown;
            }
            set
            {
                thrown = 0;
            }
        }

        public float Pop
        {
            set
            {
                Radius = 0;
            }
        }

        public int Throw
        {
            set
            {
                if (Radius > 0)
                {
                    Thrown += 1;
                }
            }
        }

        public int GetTimesThrown => Thrown;
    }
}