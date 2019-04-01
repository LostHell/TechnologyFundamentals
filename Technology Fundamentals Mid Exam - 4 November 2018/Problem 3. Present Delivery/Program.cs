using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();


            while (command[0] != "Merry Xmas!")
            {
                int index = input.IndexOf(int.Parse(command[1]))-1;
                if (command[0] == "Jump")
                {
                    if (index > input.Count)
                    {
                        index -= input.Count;
                    }
                    else
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (index == i)
                            {
                                int number = input[i];
                                input[i] = number - 2;
                            }
                        }
                    }
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
