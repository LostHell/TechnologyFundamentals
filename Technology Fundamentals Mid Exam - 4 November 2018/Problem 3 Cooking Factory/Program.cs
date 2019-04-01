using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3_Cooking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("#").ToList();

            int num = 0;
            int bestNum = 0;
            string partition = "";
            string bestPartition = "";

            while (input[0] != "Bake It!")
            {
                num = 0;
                partition = string.Empty;
                for (int i = 0; i < input.Count; i++)
                {
                    num += int.Parse(input[i]);
                    partition += input[i] + " ";
                }
                if (bestNum < num)
                {
                    bestNum = num;
                    bestPartition = partition;
                }
                input = Console.ReadLine().Split("#").ToList();
            }
            Console.WriteLine($"Best Batch quality: {bestNum}");
            bestPartition.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(string.Join(" ", bestPartition));
        }
    }
}

