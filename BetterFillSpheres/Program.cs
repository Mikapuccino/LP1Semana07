using System;

namespace BetterFillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Color color1 = new Color { Red = 200, Green = 10, Blue = 150};
            Color color2 = new Color { Red = 0, Green = 255, Blue = 0};
            Color color3 = new Color { Red = 50, Green = 100, Blue = 250};

            Console.WriteLine("Color 1 values: ");
            Console.WriteLine(color1.Red);
            Console.WriteLine(color1.Green);
            Console.WriteLine(color1.Blue);
            Console.WriteLine(color1.Alpha);
            Console.WriteLine(color1.Grey);

            Sphere sphere1 = new Sphere { Color = color1, Radius = 2};
            Sphere sphere2 = new Sphere { Color = color2, Radius = 180};
            Sphere sphere3 = new Sphere { Color = color3, Radius = 42};

            Console.WriteLine("Sphere 1 colors: ");
            Console.WriteLine(sphere1.Color.Red);
            Console.WriteLine(sphere1.Color.Green);
            Console.WriteLine(sphere1.Color.Blue);

            Console.WriteLine("Sphere 2 colors: ");
            Console.WriteLine(sphere2.Color.Red);
            Console.WriteLine(sphere2.Color.Green);
            Console.WriteLine(sphere2.Color.Blue);

            Console.WriteLine("Sphere 3 colors: ");
            Console.WriteLine(sphere3.Color.Red);
            Console.WriteLine(sphere3.Color.Green);
            Console.WriteLine(sphere3.Color.Blue);

            Console.WriteLine("Sphere 1 radius: ");
            Console.WriteLine(sphere1.Radius);

            Console.WriteLine("Sphere 2 radius: ");
            Console.WriteLine(sphere2.Radius);

            Console.WriteLine("Sphere 3 radius: ");
            Console.WriteLine(sphere3.Radius);

            for (int i = 0; i < 3; i++)
                sphere1.Throw();
            
            Console.WriteLine("Sphere 1 times thrown: ");
            Console.WriteLine(sphere1.GetTimesThrown);

            for (int i = 0; i < 2; i++)
                sphere2.Throw();
            
            sphere2.Pop();
            sphere2.Throw();

            Console.WriteLine("Sphere 2 times thrown: ");
            Console.WriteLine(sphere2.GetTimesThrown);

            sphere3.Pop();
            for (int i = 0; i < 3; i++)
                sphere3.Throw();

            Console.WriteLine("Sphere 3 times thrown: ");
            Console.WriteLine(sphere3.GetTimesThrown);

            Console.WriteLine("Sphere 1 radius: ");
            Console.WriteLine(sphere1.Radius);

            Console.WriteLine("Sphere 2 radius: ");
            Console.WriteLine(sphere2.Radius);

            Console.WriteLine("Sphere 3 radius: ");
            Console.WriteLine(sphere3.Radius);
        }
    }
}
