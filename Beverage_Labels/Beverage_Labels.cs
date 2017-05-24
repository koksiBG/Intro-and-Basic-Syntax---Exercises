using System;

namespace Beverage_Labels
{
    class Beverage_Labels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int kcal = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{volume / (double)100 * kcal}kcal, {volume / (double)100 * g}g sugars");
        }
    }
}