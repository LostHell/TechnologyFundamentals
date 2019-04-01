using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2_Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> rooms = Console.ReadLine().Split("|").ToList();

            int energy = 100;
            int coins = 100;
            string nameRoom = "";
            int number = 0;

            for (int i = 0; i < rooms.Count; i++)
            {
                List<string> command = new List<string>(rooms[i].Split("-").ToList());
                nameRoom = command[0];
                number = int.Parse(command[1]);

                if (nameRoom == "rest")
                {
                    if (number + energy > 100)
                    {
                        Console.WriteLine($"You gained 0 energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                    else
                    {
                        energy += number;
                        Console.WriteLine($"You gained {number} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                }
                if (nameRoom == "order")
                {
                    if (energy - 30 >= 0)
                    {
                        energy -= 30;
                        coins += number;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        Console.WriteLine("You had to rest!");
                        energy += 50;
                    }
                }
                if (nameRoom != "rest" && nameRoom != "order")
                {
                    coins -= number;
                    if (coins > 0)
                    {
                        Console.WriteLine($"You bought {nameRoom}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {nameRoom}.");
                        break;
                    }
                }
            }
            if (coins > 0 && energy > 0)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
            }
        }
    }
}
