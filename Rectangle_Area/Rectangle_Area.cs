using System;

namespace Rectangle_Area
{
    class Rectangle_Area
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{width * height:f2}");
        }
    }
}