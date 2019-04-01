using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            List<Students> student = new List<Students>();

            for (int i = 0; i < people; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                string firstName = input[0];
                string lastName = input[1];
                string grade = input[2];


                Students studentsSort = new Students(firstName, lastName, grade);
                student.Add(studentsSort);
            }

            student = student.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, student));
        }
    }
    public class Students
    {
        public string FirstName;
        public string LastName;
        public string Grade;

        public Students(string firstName, string lastName, string grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + ": " + Grade;
        }
    }
}
