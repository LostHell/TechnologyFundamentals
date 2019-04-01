using System;
using System.Collections.Generic;
using System.Linq;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string text = string.Empty;

            for (int i = 0; i < inputText.Length - 1; i++)
            {
                if (inputText[i] != inputText[i + 1])
                {
                    text += (char)inputText[i];
                }
            }
            text += inputText[inputText.Length - 1];
            Console.WriteLine(string.Join("", text));
        }
    }
}
