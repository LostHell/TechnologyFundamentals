using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine().Split("&").ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "Finished!")
            {
                if (command[0] == "Bad")
                {
                    if (input.Contains(command[1]))
                    {

                    }
                    else
                    {
                        input.Insert(0, command[1]);
                    }

                }
                if (command[0] == "Good")
                {
                    if (input.Contains(command[1]))
                    {
                        input.Remove(command[1]);
                    }
                }
                if (command[0] == "Rename")
                {
                    string name = command[1];
                    string secName = command[2];
                    int position = input.IndexOf(command[1]);
                    if (input.Contains(command[1]))
                    {
                        input.Remove(command[1]);
                        input.Insert(position, command[2]);
                    }
                }
                if (command[0] == "Rearrange")
                {
                    input.Remove(command[1]);
                    input.Add(command[1]);
                }
                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
