﻿using System;

namespace Character_Stats
{
    class Character_Stats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            if (currentHealth <= maximumHealth)
            {
                Console.WriteLine($"Health: " + "|" + new string('|', currentHealth) + new string('.', maximumHealth - currentHealth) + "|");
            }
            if (currentEnergy <= maximumEnergy)
            {
                Console.WriteLine($"Energy: " + "|" + new string('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy) + "|");
            }
        }
    }
}
