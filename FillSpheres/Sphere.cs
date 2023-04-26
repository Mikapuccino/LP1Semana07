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

        public Color GetColor()
        {
            return color;
        }

        public void SetColor(Color newColor)
        {
            color = newColor;
        }

        public float GetRadius()
        {
            return radius;
        }

        public void SetRadius(float newRadius)
        {
            radius = newRadius;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                thrown =+ 1;
            }
        }

        public int GetTimesThrown()
        {
            return thrown;
        }
    }
}