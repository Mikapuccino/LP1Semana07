using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Color color1 = new Color(200, 10, 150);
            Color color2 = new Color(0, 255, 0);
            Color color3 = new Color(50, 100, 250);

            Console.WriteLine(color1.GetRed());
            Console.WriteLine(color1.GetGreen());
            Console.WriteLine(color1.GetBlue());
            Console.WriteLine(color1.GetAlpha());
            Console.WriteLine(color1.GetGrey());

            Sphere sphere1 = new Sphere(color1, 2);
            Sphere sphere2 = new Sphere(color2, 180);
            Sphere sphere3 = new Sphere(color3, 42);

            sphere1.GetColor();
            sphere2.GetColor();
            sphere3.GetColor();

            sphere1.Throw();
            sphere1.Throw();
            sphere1.Throw();
            Console.WriteLine(sphere1.GetTimesThrown());
            sphere1.SetColor(color2);
            sphere1.GetColor();

            sphere2.Throw();
            sphere2.Throw();
            sphere2.Pop();
            sphere2.Throw();
            Console.WriteLine(sphere2.GetTimesThrown());

            sphere3.Pop();
            sphere3.Throw();
            sphere3.Throw();
            sphere3.Throw();
            Console.WriteLine(sphere3.GetTimesThrown());
        }
    }
}
