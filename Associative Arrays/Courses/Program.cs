using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courseAndStudent = Console.ReadLine().Split(" :").ToList();
            var names = new SortedDictionary<string, List<string>>();
            var courses = new Dictionary<string, int>();

            while (courseAndStudent[0] != "end")
            {
                if (!courses.ContainsKey(courseAndStudent[0]))
                {
                    names.Add(courseAndStudent[0], new List<string>());
                    names[courseAndStudent[0]].Add(courseAndStudent[1]);
                    courses[courseAndStudent[0]] = 1;
                }
                else
                {
                    names[courseAndStudent[0]].Add(courseAndStudent[1]);
                    courses[courseAndStudent[0]]++;
                }
                courseAndStudent = Console.ReadLine().Split(" :").ToList();
            }

            foreach (var kvp in courses.OrderByDescending(x => x.Value))
            {
                var index = kvp.Key;
                int counter = kvp.Value;
                var listName = names[index].OrderBy(y => y).ToList();
                Console.WriteLine($"{index}: {counter}");
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine($"--{listName[i]}");
                }
            }
        }
    }
}