using System;
using System.Collections.Generic;
using System.Linq;

namespace Technology_Fundamentals_Final_Exam_16_Dec_2018
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> inputData = Console.ReadLine().Split("; ").ToList();
            SortedDictionary<string, int> points = new SortedDictionary<string, int>();
            Dictionary<string, List<string>> nameList = new Dictionary<string, List<string>>();
            int totalTime = 0;

            while (inputData[0] != "start of concert")
            {
                if (inputData[0] == "Play")
                {
                    if (!points.ContainsKey(inputData[1]))
                    {
                        points[inputData[1]] = int.Parse(inputData[2]);
                    }
                    else
                    {
                        points[inputData[1]] += int.Parse(inputData[2]);
                    }
                    totalTime += int.Parse(inputData[2]);
                }
                else if (inputData[0] == "Add")
                {
                    if (!nameList.ContainsKey(inputData[1]))
                    {
                        nameList[inputData[1]] = new List<string>();
                    }
                    List<string> names = inputData[2].Split(", ").ToList();
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (!nameList[inputData[1]].Contains(names[i]))
                        {
                            nameList[inputData[1]].Add(names[i]);
                        }
                    }
                }
                inputData = Console.ReadLine().Split("; ").ToList();
            }
            string inputBand = Console.ReadLine();
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var item in points.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            foreach (var item in nameList)
            {
                if (inputBand == item.Key)
                {
                    var index = item.Value;
                    Console.WriteLine(item.Key);
                    for (int i = 0; i < index.Count; i++)
                    {
                        Console.WriteLine($"=> {index[i]}");
                    }
                }
            }
        }
    }
}
