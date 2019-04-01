using System;
using System.Collections.Generic;
using System.Linq;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNUmber = Console.ReadLine().Split().ToList();
            string leftSide = inputNUmber[0];
            string rightSide = inputNUmber[1];
            string longer = string.Empty;
            string shortWord = string.Empty;

            int sum = 0;

            if (leftSide.Length >= rightSide.Length)
            {
                longer = leftSide;
                shortWord = rightSide;
            }
            else
            {
                longer = rightSide;
                shortWord = leftSide;
            }

            for (int i = 0; i < shortWord.Length; i++)
            {
                sum += longer[i] * shortWord[i];
            }
            for (int i = shortWord.Length; i < longer.Length; i++)
            {
                sum += longer[i];
            }
            Console.WriteLine(sum);
        }
    }
}
