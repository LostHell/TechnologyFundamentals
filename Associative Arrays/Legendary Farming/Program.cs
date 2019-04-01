using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new Dictionary<string, int>();
            var junkElements = new Dictionary<string, int>();
            elements["shards"] = 0;
            elements["fragments"] = 0;
            elements["motes"] = 0;


            //3 Motes 5 stones 5 Shards
            //6 leathers 255 fragments 7 Shards
            while (true)
            {
                bool winner = false;
                var command = Console.ReadLine().ToLower().Split(" ").ToList();

                for (int i = 0; i < command.Count; i += 2)
                {
                    string type = command[i + 1];
                    int quantity = int.Parse(command[i]);

                    if (type == "motes" || type == "fragments" || type == "shards")
                    {
                        if (!elements.ContainsKey(type))
                        {
                            elements.Add(type, quantity);
                        }
                        else
                        {
                            elements[type] += quantity;
                        }
                    }
                    else
                    {
                        if (!junkElements.ContainsKey(type))
                        {
                            junkElements.Add(type, quantity);
                        }
                        else
                        {
                            junkElements[type] += quantity;
                        }
                    }
                    if (elements["shards"] >= 250 || elements["fragments"] >= 250 || elements["motes"] >= 250)
                    {
                        elements[type] = elements[type] - 250;
                        if (type == "shards")
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                        }
                        else if (type == "fragments")
                        {
                            Console.WriteLine("Valanyr obtained!");
                        }
                        else if (type == "motes")
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                        }
                        winner = true;
                        break;
                    }
                }
                if (winner)
                {
                    break;
                }
            }
            foreach (var kvp in elements.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkElements.OrderBy(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
