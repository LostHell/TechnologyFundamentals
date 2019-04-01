using System;

namespace Problem_1_Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flour = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double apron = double.Parse(Console.ReadLine());


            int freeFlour = 0;
            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freeFlour++;
                }
            }

            double apronPrice = apron * Math.Ceiling(students * 1.20);
            double priceEggs = eggs * 10 * students;
            double priceFlour = flour * (students - freeFlour);

            double allPrice = apronPrice + priceEggs + priceFlour;

            if (budget >= allPrice)
            {
                Console.WriteLine($"Items purchased for {allPrice:F2}$.");
            }
            else
            {
                Console.WriteLine($"{(allPrice - budget):F2}$ more needed."
);
            }
        }
    }
}
