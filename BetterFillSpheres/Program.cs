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
        }
    }
}
