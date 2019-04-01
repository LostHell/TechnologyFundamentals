using System;
using System.Collections.Generic;
using System.Linq;

namespace Tech_Module_Mid_Exam___The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = Console.ReadLine().Split().ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "Stop")
            {
                if (command[0] == "Swap")
                {
                    if (inputText.Contains(command[1]) && inputText.Contains(command[2]))
                    {
                        int index = inputText.IndexOf(command[1]);
                        inputText.Insert(index, command[2]);
                        inputText.RemoveAt(index + 1);
                        int nextIndex = inputText.IndexOf(command[2]);
                        inputText.Insert(nextIndex, command[1]);
                        inputText.RemoveAt(nextIndex + 1);
                    }
                }
                else if (command[0] == "Replace")
                {
                    if (inputText.Contains(command[2]))
                    {
                        int index = inputText.IndexOf(command[2]);
                        inputText.Insert(index, command[1]);
                        inputText.RemoveAt(index + 1);
                    }
                }
                else if (command[0] == "Delete")
                {
                    if (int.Parse(command[1]) >= 0 && inputText.Count - 1 > int.Parse(command[1]))
                    {
                        inputText.RemoveAt(int.Parse(command[1]) + 1);
                    }
                }
                else if (command[0] == "Put")
                {
                    if (int.Parse(command[2]) - 1 >= 0 && int.Parse(command[2]) - 1 < inputText.Count)
                    {
                        inputText.Insert(int.Parse(command[2]) - 1, command[1]);
                    }
                }
                else if (command[0] == "Sort")
                {
                    inputText = inputText.OrderByDescending(x => x).ToList();
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", inputText));
        }
    }
}
