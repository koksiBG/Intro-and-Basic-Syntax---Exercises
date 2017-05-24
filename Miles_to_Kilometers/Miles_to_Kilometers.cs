using System;

namespace Miles_to_Kilometers
{
    class Miles_to_Kilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine($"{miles * 1.60934:f2}");
        }
    }
}