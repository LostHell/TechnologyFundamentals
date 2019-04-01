using System;

namespace MId_Exam_10._03._2018
{
    class Program
    {
        static void Main(string[] args)
        {

            long days = long.Parse(Console.ReadLine());
            int player = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double currentWater = 0;
            double currentFood = 0;
            int lvl = 0;

            currentWater = days * player * water;
            currentFood = days * player * food;

            for (int i = 1; i <= days; i++)
            {

                lvl = i;
                double currentEnergy = double.Parse(Console.ReadLine());
                energy -= currentEnergy;
                if (i % 2 == 0)
                {
                    energy = energy * 1.05;
                    currentWater = currentWater * 0.70;
                }
                if (i % 3 == 0)
                {
                    currentFood -= currentFood / player;
                    energy *= 1.10;
                }
                if (energy < 0)
                {
                    break;
                }

            }
            if (energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {currentFood:F2} food and {currentWater:F2} water.");
            }

        }
    }
}
