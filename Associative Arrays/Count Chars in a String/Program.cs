using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<char> input = Console.ReadLine()
                .Where(x => x != ' ')
                .ToList();
            Dictionary<char, int> word = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (!word.ContainsKey(character))
                {
                    word[character] = 0;
                }
                word[character]++;
            }
            foreach (var item in word)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
