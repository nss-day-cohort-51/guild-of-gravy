using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {
        public static List<TeamMember> Team = new List<TeamMember>();
        public static int BankDifficultyLevel;
        public static int TeamSkillLevel;
        public static int HeistLuck;
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.Write("Bank Difficulty Level: ");
            BankDifficultyLevel = int.Parse(Console.ReadLine());
            Console.WriteLine();
            AddTeamMember();
        }

        public static void AddTeamMember()
        {
            TeamMember member1 = new TeamMember();
            Console.Write("Enter team member name: ");
            member1.Name = Console.ReadLine();
            RunHeist(member1.Name);
            Console.Write($"Enter {member1.Name}'s skill level: ");
            member1.SkillLevel = int.Parse(Console.ReadLine());

            Console.Write($"Enter {member1.Name}'s courage factor: ");
            member1.CourageFactor = decimal.Parse(Console.ReadLine());
            Team.Add(member1);
            Console.WriteLine("Team member added!");
            Console.WriteLine();
            TeamSkillLevel += member1.SkillLevel;

            AddTeamMember();
        }

        public static void RunHeist(string memberName)
        {
            if (string.IsNullOrWhiteSpace(memberName))
            {
                Console.Write("How many times do you want this to run? ");
                int trialRuns = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int success = 0;
                int failed = 0;
                for (int i = 0; i < trialRuns; i++)
                {
                    HeistLuck = new Random().Next(-10, 10);
                    BankDifficultyLevel += HeistLuck;
                    Console.WriteLine($"Team Skill Level: {TeamSkillLevel}");
                    Console.WriteLine("Bank Difficulty Level: {0}", BankDifficultyLevel);
                    if (TeamSkillLevel >= BankDifficultyLevel)
                    {
                        Console.WriteLine("You successfully robbed the bank!");
                        success += 1;
                    }
                    else
                    {
                        Console.WriteLine("Uh oh! You and your team got caught :(");
                        failed += 1;
                    }
                    Console.WriteLine();
                    BankDifficultyLevel -= HeistLuck;
                }
                Console.WriteLine($"==== Heist Report ====");
                Console.WriteLine($"Successful Runs: {success}");
                Console.WriteLine($"Failed Runs: {failed}");
                Environment.Exit(0);
            }
        }
    }
}
