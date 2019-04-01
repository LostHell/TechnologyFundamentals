using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> input = new Dictionary<string, int>();
            string resource = string.Empty;

            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!input.ContainsKey(resource))
                {
                    input[resource] = quantity;
                }
                else
                {
                    input[resource] += quantity;
                }
            }
            foreach (var kvp in input)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
