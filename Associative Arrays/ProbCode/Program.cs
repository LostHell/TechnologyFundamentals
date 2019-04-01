using System;
using System.Collections.Generic;

namespace ProbCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();


            for (int i = 0; i < num; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                //Проверяваме дали я няма думата и ако я няма влиза в if.
                if (!dict.ContainsKey(word))
                {
                    //Добавяме думата и след това за нея създаваме нов лист.
                    dict[word] = new List<string>();
                }
                //Ако думата е създадена с листа просто добавяме нови стойности към самата дума.
                dict[word].Add(synonym);
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " -> " + string.Join(", ", item.Value));
            }
        }
    }
}
