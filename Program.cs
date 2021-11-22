using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {
        public static List<TeamMember> Team = new List<TeamMember>();
        public static int BankDifficultyLevel = 100;
        public static int TeamSkillLevel = 0;
        public static int HeistLuck;
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            AddTeamMember();
        }

        public static void AddTeamMember()
        {
            TeamMember member1 = new TeamMember();
            Console.Write("Enter team member name: ");
            member1.Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(member1.Name))
            {

                Console.Write("How many times do you want this to run? ");
                int trialRuns = int.Parse(Console.ReadLine());
                for (int i = 0; i < trialRuns; i++)
                {
                    HeistLuck = new Random().Next(-10, 10);
                    BankDifficultyLevel += HeistLuck;
                    Console.WriteLine($"Team Skill Level: {TeamSkillLevel}");
                    Console.WriteLine("Bank Difficulty Level: {0}", BankDifficultyLevel);
                    if (TeamSkillLevel >= BankDifficultyLevel)
                    {
                        Console.WriteLine("You succesfully robbed the bank!");
                        // Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Uh oh! You and your team got caught :(");
                        // Environment.Exit(0);
                    }
                }
                Environment.Exit(0);
            }
            Console.Write($"Enter {member1.Name}'s skill level: ");
            member1.SkillLevel = int.Parse(Console.ReadLine());

            Console.Write($"Enter {member1.Name}'s courage factor: ");
            member1.CourageFactor = decimal.Parse(Console.ReadLine());
            Team.Add(member1);
            Console.WriteLine("Team member added!");

            TeamSkillLevel += member1.SkillLevel;

            AddTeamMember();
        }
    }
}
