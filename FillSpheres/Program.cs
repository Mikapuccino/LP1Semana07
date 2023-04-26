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

            Console.WriteLine("Color 1 values: ");
            Console.WriteLine(color1.GetRed());
            Console.WriteLine(color1.GetGreen());
            Console.WriteLine(color1.GetBlue());
            Console.WriteLine(color1.GetAlpha());
            Console.WriteLine(color1.GetGrey());

            Sphere sphere1 = new Sphere(color1, 2);
            Sphere sphere2 = new Sphere(color2, 180);
            Sphere sphere3 = new Sphere(color3, 42);

            byte[] sphere1Colors = sphere1.GetColor();
            Console.WriteLine("Sphere 1 colors: ");
            for (int i = 0; i < sphere1Colors.Length; i++)
                Console.WriteLine(sphere1Colors[i]);

            byte[] sphere2Colors = sphere2.GetColor();
            Console.WriteLine("Sphere 2 colors: ");
            for (int i = 0; i < sphere2Colors.Length; i++)
                Console.WriteLine(sphere2Colors[i]);
            
            byte[] sphere3Colors = sphere3.GetColor();
            Console.WriteLine("Sphere 3 colors: ");
            for (int i = 0; i < sphere3Colors.Length; i++)
                Console.WriteLine(sphere3Colors[i]);

            sphere1.Throw();
            sphere1.Throw();
            sphere1.Throw();
            Console.WriteLine("Sphere 1 times thrown: ");
            Console.WriteLine(sphere1.GetTimesThrown());
            sphere1.SetColor(color2);
            sphere1Colors = sphere1.GetColor();
            Console.WriteLine("Sphere 1 colors: ");
            for (int i = 0; i < sphere1Colors.Length; i++)
                Console.WriteLine(sphere1Colors[i]);

            sphere2.Throw();
            sphere2.Throw();
            sphere2.Pop();
            sphere2.Throw();
            Console.WriteLine("Sphere 2 times thrown: ");
            Console.WriteLine(sphere2.GetTimesThrown());
            sphere2Colors = sphere2.GetColor();
            Console.WriteLine("Sphere 2 colors: ");
            for (int i = 0; i < sphere2Colors.Length; i++)
                Console.WriteLine(sphere2Colors[i]);

            sphere3.Pop();
            sphere3.Throw();
            sphere3.Throw();
            sphere3.Throw();
            Console.WriteLine("Sphere 3 times thrown: ");
            Console.WriteLine(sphere3.GetTimesThrown());
            sphere3Colors = sphere3.GetColor();
            Console.WriteLine("Sphere 3 colors: ");
            for (int i = 0; i < sphere3Colors.Length; i++)
                Console.WriteLine(sphere3Colors[i]);
        }
    }
}
