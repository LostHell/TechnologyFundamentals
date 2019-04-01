using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("#", StringSplitOptions.RemoveEmptyEntries).ToList();

            int water = int.Parse(Console.ReadLine());
            List<int> cells = new List<int>();
            double efforts = 0;
            int totalFire = 0;

            for (int i = 0; i < input.Count; i++)
            {
                List<string> command = input[i].Split("=", StringSplitOptions.RemoveEmptyEntries).ToList();
                string commandName = command[0];

                if (commandName == "High ")
                {
                    if (int.Parse(command[1]) >= 81 && int.Parse(command[1]) <= 125 && water >= int.Parse(command[1]))
                    {
                        int num = int.Parse(command[1]);
                        water -= num;
                        cells.Add(num);
                        totalFire += num;
                        efforts += num * 0.25;
                    }
                }
                if (commandName == "Medium ")
                {
                    if (int.Parse(command[1]) >= 51 && int.Parse(command[1]) <= 80 && water >= int.Parse(command[1]))
                    {
                        int num = int.Parse(command[1]);
                        water -= num;
                        cells.Add(num);
                        totalFire += num;
                        efforts += num * 0.25;
                    }
                }
                if (commandName == "Low ")
                {
                    if (int.Parse(command[1]) >= 1 && int.Parse(command[1]) <= 50 && water >= int.Parse(command[1]))
                    {
                        int num = int.Parse(command[1]);
                        water -= num;
                        cells.Add(num);
                        totalFire += num;
                        efforts += num * 0.25;
                    }
                }
                if (water <= 0)
                {
                    break;
                }

            }
            Console.WriteLine("Cells:");
            for (int i = 0; i < cells.Count; i++)
            {
                Console.WriteLine($" - {cells[i]}");
            }
            Console.WriteLine($"Effort: {efforts:F2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
