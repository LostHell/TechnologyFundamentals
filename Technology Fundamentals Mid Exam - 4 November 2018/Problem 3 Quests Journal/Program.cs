using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3_Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine().Split(", ").ToList();
            List<string> command = Console.ReadLine().Split(" - ").ToList();
            bool isStart = false;
            bool isSide = false;
            bool isLastCommand = false;

            while (command[0] != "Retire!")
            {
                if (command[0] == "Start")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (command[1] == input[i])
                        {
                            isStart = true;
                        }
                    }
                    if (isStart == false)
                    {
                        input.Add(command[1]);
                    }
                }
                else if (command[0] == "Complete")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (command[1] == input[i])
                        {
                            input.Remove(command[1]);
                        }
                    }
                }
                else if (command[0] == "Side Quest")
                {
                    List<string> lastCommand = command[1].Split(":").ToList();
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (lastCommand[0] == input[i])
                        {
                            isSide = true;
                        }
                        if (lastCommand[1] == input[i])
                        {
                            isLastCommand = true;
                        }
                    }
                    if (isSide == false)
                    {
                        input.Add(lastCommand[0]);
                    }
                    if (isLastCommand == false)
                    {
                        input.Add(lastCommand[1]);
                    }

                }
                else if (command[0] == "Renew")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (command[1] == input[i])
                        {
                            input.Remove(command[1]);
                            input.Add(command[1]);
                        }
                    }
                }
                command = Console.ReadLine().Split(" - ").ToList();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
