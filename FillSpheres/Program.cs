using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Color color = new Color(200, 10, 150);

            Console.WriteLine(color.GetRed());
            Console.WriteLine(color.GetGreen());
            Console.WriteLine(color.GetBlue());
            Console.WriteLine(color.GetAlpha());
            Console.WriteLine(color.GetGrey());
        }
    }
}
