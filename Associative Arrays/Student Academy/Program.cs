using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();
            Dictionary<string, double> dict = new Dictionary<string, double>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                students[name].Add(grade);
            }

            foreach (var item in students)
            {
                var index = item.Key;
                var allGrades = students[index].OrderBy(x => item.Value).ToList();
                double result = 0;
                int countGrades = allGrades.Count;
                for (int i = 0; i < allGrades.Count; i++)
                {
                    result += allGrades[i];
                }
                dict.Add(index, result / countGrades);
            }
            foreach (var item in dict.OrderByDescending(x => x.Value))
            {
                if (item.Value >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value:F2}");
                }
            }
        }
    }
}
