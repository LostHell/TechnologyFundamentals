using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = Console.ReadLine().Split().ToList();

            string text = string.Empty;

            for (int i = 0; i < inputText.Count; i++)
            {
                if (int.Parse(inputText[i]) > 0 && int.Parse(inputText[i]) < 10)
                {
                    for (int j = i; j < i + int.Parse(inputText[i]); j++)
                    {
                        if (inputText[i + 1] != ">")
                        {
                            inputText.RemoveAt(j);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join("", inputText));
        }
    }
}