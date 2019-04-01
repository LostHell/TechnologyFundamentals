using System;
using System.Collections.Generic;
using System.Linq;

namespace Technology_Fundamentals_Mid_Exam___4_November_2018
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine().Split("|").ToList();

            int health = 100;
            int coins = 0;

            for (int i = 0; i < input.Count; i++)
            {
                List<string> currentRoom = input[i].Split().ToList();
                string command = currentRoom[0];
                int number = int.Parse(currentRoom[1]);
                if (command == "potion")
                {
                    int currentHealth = health;
                    health += number;
                    if (health > 100)
                    {
                        Console.WriteLine($"You healed for {100 - currentHealth} hp.");
                        Console.WriteLine($"Current health: 100 hp.");
                        health = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                if (command == "chest")
                {
                    coins += number;
                    Console.WriteLine($"You found {number} coins.");
                }
                if (command != "potion" && command != "chest")
                {
                    health -= number;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                }
            }
            if (health > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
