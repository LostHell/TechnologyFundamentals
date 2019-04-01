using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            int index = 0;
            while (command[0] != "Stop")
            {
                if (command[0] == "Delete")
                {
                    index = int.Parse(command[1]);
                    input.Remove(input[index]);
                }
                if (command[0] == "Swap")
                {
                    int index1 = 0;
                    int index2 = 0;
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (command[1] == input[i])
                        {
                            index1 = i;
                        }
                        if (command[2] == input[i])
                        {
                            index2 = i;
                        }

                    }
                    input.RemoveAt(index1);
                    input.Insert(index, command[2]);
                    input.RemoveAt(index2)
                }
                if (command[0] == "Put")
                {
                    int lastIndex = int.Parse(command[2]);
                    input.Insert(lastIndex - 1, command[1]);
                }
                if (command[0] == "Sort")
                {
                    input.Sort();
                }
                if (command[0] == "Replace")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (command[2] == input[i] && command[2] == "")
                        {
                            input.RemoveAt(index);
                            input.Insert(i, command[1]);
                        }
                    }
                }
                command = Console.ReadLine().Split().ToList();
            }
            foreach (var text in input)
            {
                Console.WriteLine(text);
            }
        }
    }
}
