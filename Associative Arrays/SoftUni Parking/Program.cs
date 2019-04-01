using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            var parkedPeople = new Dictionary<string, string>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "register")
                {
                    if (!parkedPeople.ContainsKey(command[1]))
                    {
                        parkedPeople[command[1]] = command[2];
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                    }
                }
                if (command[0] == "unregister")
                {
                    if (parkedPeople.ContainsKey(command[1]))
                    {
                        parkedPeople.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }
            foreach (var names in parkedPeople)
            {
                Console.WriteLine($"{names.Key} => {names.Value}");
            }
        }
    }
}
