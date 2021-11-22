using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {
        public static List<TeamMember> Team = new List<TeamMember>();
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            TeamMember member1 = new TeamMember();
            Console.Write("Enter team member name: ");
            member1.Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(member1.Name))
            {
                Console.WriteLine("Done!");
                Environment.Exit(0);
            }

            Console.Write($"Enter {member1.Name}'s skill level: ");
            member1.SkillLevel = int.Parse(Console.ReadLine());

            Console.Write($"Enter {member1.Name}'s courage factor: ");
            member1.CourageFactor = decimal.Parse(Console.ReadLine());
            Team.Add(member1);
            Console.WriteLine($"There are {Team.Count} team members in your team.");
            foreach (TeamMember member in Team)
            {
                Console.WriteLine($@"
                    Member Name: {member.Name}
                    Member Skill Level: {member.SkillLevel}
                    Member Courage Factor: {member.CourageFactor}
                ");
            }
            member1 = null;
            Main(new string[] { });
        }
    }
}
