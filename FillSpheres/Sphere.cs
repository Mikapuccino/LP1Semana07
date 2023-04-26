using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Sphere
    {
        private Color color;
        private float radius;
        private int thrown;

        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            thrown = 0;
        }
    }
}