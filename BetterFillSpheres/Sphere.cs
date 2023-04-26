using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Sphere
    {        
        public Color Color { get; set; }
        public float Radius { get; set; }
        private int Thrown { get; set; } = 0;

        // Sets radius to 0
        public void Pop()
        {
            Radius = 0;
        }

        // Increments times thrown if radius is bigger than 0
        public void Throw()
        {
            if (Radius > 0)
            {
                Thrown += 1;
            }
        }

        // Returns times sphere was thrown
        public int GetTimesThrown => Thrown;
    }
}