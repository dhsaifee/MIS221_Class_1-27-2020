using System;

namespace MIS221_Class_1_27_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string presidentName = GetPresidentName();
            string companyName = GetCompanyName();
            WelcomeMessage(presidentName, companyName);
            Console.WriteLine();
            int numAttended = GetMeetingsAttended();
            const int REQ_MEET = 5;
            DisplayMeetingsLeft(numAttended, REQ_MEET);

            Console.ReadKey();
        }

        static void DisplayMeetingsLeft(int meetingsAttended, int meetingsRequired)
        {
            int meetingsLeft = meetingsRequired - meetingsAttended;
            Console.WriteLine("You need to attend " + meetingsLeft + " more meeting(s)");
        }

        static int GetMeetingsAttended()
        {
            Console.Write("Enter # of meetings attended: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static void WelcomeMessage(string x, string y)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to AIMS! My name is " + x);
            Console.WriteLine(y + " is coming next week!");
        }

        static string GetCompanyName()
        {
            Console.Write("Enter name of company: ");
            string name = Console.ReadLine();
            return name;
        }

        static string GetPresidentName()
        {
            Console.Write("Enter name of president: ");
            string name = Console.ReadLine();
            return name;
        }

    }
}
