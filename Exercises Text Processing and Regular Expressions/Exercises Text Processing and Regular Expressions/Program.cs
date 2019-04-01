using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises_Text_Processing_and_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ")
                .ToList();

            List<string> text = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                string word = input[i];
                bool IsTrue = false;

                if (word.Length >= 3 && word.Length <= 16)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        char symbol = word[j];
                        if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                        {
                            text.Add(input[i]);
                            IsTrue = true;
                        }
                        else
                        {
                            IsTrue = false;
                            break;
                        }
                    }
                }
                if (IsTrue == true)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, word));
                }
            }

        }
    }
}
