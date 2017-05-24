using System;

namespace Debit_Card_Number
{
    class Debit_Card_Number
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwoo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numberOne:D4} {numberTwoo:D4} {numberThree:D4} {numberFour:D4}");
        }
    }
}