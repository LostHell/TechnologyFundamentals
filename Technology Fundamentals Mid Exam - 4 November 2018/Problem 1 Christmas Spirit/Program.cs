using System;

namespace Problem_1_Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int ornametSet = 2;
            int TreeSkirt = 5;
            int TreeGarlands = 3;
            int TreeLights = 15;
            int sumPrice = 0;
            int sumSpirit = 0;


            for (int currenday = 1; currenday <= days; currenday++)
            {
                if (currenday % 2 == 0)
                {
                    sumPrice += ornametSet * quantity;
                    sumSpirit += 5;
                }
                if (currenday % 3 == 0)
                {
                    sumPrice += TreeSkirt * quantity + TreeGarlands * quantity;
                    sumSpirit += 13;
                }
                if (currenday % 5 == 0)
                {
                    sumPrice += TreeLights * quantity;
                    sumSpirit += 17;
                    if (currenday % 3 == 0)
                    {
                        sumSpirit += 30;
                    }
                }
                if (currenday % 10 == 0)
                {
                    if (days > 10)
                    {
                        sumSpirit -= 20;
                        quantity += 2;
                        sumPrice += TreeSkirt + TreeGarlands + TreeLights;
                    }
                }
            }
            if (days % 10 == 0)
            {
                sumSpirit -= 30;
            }
            Console.WriteLine($"Total cost: {sumPrice}");
            Console.WriteLine($"Total spirit: {sumSpirit}");
        }
    }
}
