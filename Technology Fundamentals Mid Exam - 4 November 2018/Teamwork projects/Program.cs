using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {

            int teamCount = int.Parse(Console.ReadLine());
            List<string> team = new List<string>();
            List<TeamsName> people = new List<TeamsName>();

            for (int i = 0; i < teamCount; i++)
            {
                List<string> input = Console.ReadLine().Split("-").ToList();
                string name = input[0];
                string groupName = input[1];


                TeamsName teams = new TeamsName(groupName);
                people.Add(teams);
            }

            List<string> command = Console.ReadLine().Split("->").ToList();

            while (command[0] != "end of assignment")
            {
                

            }
        }
    }

    public class TeamsName
    {
        public string GroupName;

        public TeamsName(string groupName)
        {
            GroupName = groupName;
        }
    }
}
