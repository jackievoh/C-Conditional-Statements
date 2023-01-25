using System;

namespace Deliverable2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            try
            {
                int grade = int.Parse(Console.ReadLine());
                string letter_grade = string.Empty;

                if (grade >= 90) letter_grade = "A";
                else if (grade >= 80) letter_grade = "B";   
                else if (grade >= 70) letter_grade = "C";
                else if (grade >= 60) letter_grade = "D";
                else if (grade >= 0) letter_grade = "F";

                Console.WriteLine("Your letter grade is " + letter_grade);


            }
            catch (Exception e)
            {
                Console.WriteLine("Error, please enter a valid number!");
                throw;
            }

        }
    }
}