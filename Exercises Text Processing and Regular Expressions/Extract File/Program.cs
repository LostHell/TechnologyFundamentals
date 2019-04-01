using System;
using System.Collections.Generic;
using System.Linq;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("")
                .ToList();

            string encrypt = string.Empty;
            string word = string.Empty;

            for (int i = 0; i < input.Count; i++)
            {
                word = input[i];
                for (int j = 0; j < word.Length; j++)
                {
                    encrypt += (char)(word[j] + 3);
                }
            }
            Console.WriteLine(encrypt);
        }
    }
}
