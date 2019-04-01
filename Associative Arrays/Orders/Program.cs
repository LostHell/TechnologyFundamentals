using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine().Split().ToList();
            var productsPrice = new Dictionary<string, double>();
            var productsQuantity = new Dictionary<string, int>();
            string name = string.Empty;
            double price = 0;
            int quantity = 0;

            while (input[0] != "buy")
            {
                name = input[0];
                price = double.Parse(input[1]);
                quantity = int.Parse(input[2]);

                if (!productsPrice.ContainsKey(name))
                {
                    productsPrice[name] = price;
                    productsQuantity[name] = quantity;
                }
                else
                {
                    productsPrice[name] = price;
                    productsQuantity[name] += quantity;
                }

                input = Console.ReadLine().Split().ToList();
            }
            
            foreach (var item in productsPrice)
            {
                var index = item.Key;
                var lastPrice = item.Value;
                var lastQuantity = productsQuantity[index];
                Console.WriteLine($"{index} -> {(lastPrice * lastQuantity):F2}");
            }
        }
    }
}
