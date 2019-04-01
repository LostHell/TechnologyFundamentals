using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Dictionary<string, int>();
            var submission = new Dictionary<string, int>();

            List<string> command = Console.ReadLine().Split("-").ToList();
            while (command[0] != "exam finished")
            {
                string name = command[0];
                string course = command[1];
                

                if (course == "banned")
                {
                    student.Remove(name);
                }
                else
                {
                    int points = int.Parse(command[2]);
                    if (!student.ContainsKey(name))
                    {
                        student[name] = points;
                    }
                    else if (points > student[name])
                    {
                        student[name] = points;
                    }
                    if (!submission.ContainsKey(course))
                    {
                        submission[course] = 0;
                    }
                    submission[course]++;
                }
                command = Console.ReadLine().Split("-").ToList();
            }
            Console.WriteLine("Results:");
            foreach (var item in student.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in submission.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
