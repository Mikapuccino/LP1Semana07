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

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
            {
                thrown += 1;
            }
        }

        public int GetTimesThrown => Thrown;
    }
}