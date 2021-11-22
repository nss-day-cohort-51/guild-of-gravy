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
            Write("Bank Difficulty Level: ");
            BankDifficultyLevel = int.Parse(ReadLine());
            Console.Clear();
            AddTeamMember();
        }

        public static void AddTeamMember()
        {
            TeamMember member1 = new TeamMember();
            Write("Enter team member name or press Enter if finished: ");
            member1.Name = ReadLine();
            RunHeist(member1.Name);
            Write($"Enter {member1.Name}'s skill level: ");
            member1.SkillLevel = int.Parse(ReadLine());

            Write($"Enter {member1.Name}'s courage factor: ");
            member1.CourageFactor = decimal.Parse(ReadLine());
            Team.Add(member1);
            Console.Clear();
            WriteLine("Team member added!");
            Console.WriteLine();
            TeamSkillLevel += member1.SkillLevel;

            AddTeamMember();
        }

        public static void RunHeist(string memberName)
        {
            if (string.IsNullOrWhiteSpace(memberName))
            {
                Console.Clear();
                Write("How many times do you want this to run? ");
                int trialRuns = int.Parse(ReadLine());
                Console.Clear();
                int success = 0;
                int failed = 0;
                for (int i = 0; i < trialRuns; i++)
                {
                    HeistLuck = new Random().Next(-10, 10);
                    BankDifficultyLevel += HeistLuck;
                    WriteLine($"Team Skill Level: {TeamSkillLevel}");
                    WriteLine($"Bank Difficulty Level: {BankDifficultyLevel}");
                    if (TeamSkillLevel >= BankDifficultyLevel)
                    {
                        WriteLine("You successfully robbed the bank!");
                        success += 1;
                    }
                    else
                    {
                        WriteLine("Uh oh! You and your team got caught :(");
                        failed += 1;
                    }
                    Console.WriteLine();
                    BankDifficultyLevel -= HeistLuck;
                }
                WriteLine($"==== Heist Report ====");
                WriteLine($"Successful Runs: {success}");
                WriteLine($"Failed Runs: {failed}");
                Environment.Exit(0);
            }
        }

        public static void WriteLine(string stringInput)
        {
            Console.WriteLine(stringInput);
        }

        public static void Write(string stringInput)
        {
            Console.Write(stringInput);
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
