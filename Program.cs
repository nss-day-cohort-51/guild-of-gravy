using System;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            TeamMember member1 = new TeamMember();

            Console.Write("Enter team member name: ");
            member1.Name = Console.ReadLine();

            Console.Write($"Enter {member1.Name}'s skill level: ");
            member1.SkillLevel = int.Parse(Console.ReadLine());

            Console.Write($"Enter {member1.Name}'s courage factor: ");
            member1.CourageFactor = decimal.Parse(Console.ReadLine());

            Console.WriteLine($@"
                Member Name: {member1.Name}
                Member Skill Level: {member1.SkillLevel}
                Member Courage Factor: {member1.CourageFactor}
            ");
        }
    }
}
