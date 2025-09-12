// HW1b Grade
//Hw1b

// Your Name:Sami Yousef
// Did you seek help ? If yes, specify the helper or web link here: Claude.ai
// Used to help further explain when my code was mistaken was having error.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string LastName = Console.ReadLine();
            Console.WriteLine("What is your Student ID?");
            string StudentID = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for assignment?");
            double Assignments = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for participation?");
            double Participation = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double Quizzes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            double Exam1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Exam 2?");
            double Exam2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Exam 3?");
            double Exam3 = Convert.ToDouble(Console.ReadLine());

            const double Assignments_Weight = .20;
            const double Participation_Weight = .15;
            const double Quizzes_Weight = 0;
            const double Exam1_Weight = .15;
            const double Exam2_Weight = .25;
            const double Exam3_Weight = .25;

            double FinalGrade = (Assignments * Assignments_Weight) + (Participation * Participation_Weight) + (Quizzes * Quizzes_Weight) + (Exam1 * Exam1_Weight) + (Exam2 * Exam2_Weight) + (Exam3 * Exam3_Weight);

            Console.WriteLine($"\n{FirstName} {LastName} ({StudentID}), your final grade is {FinalGrade:F2}%");

            Console.ReadKey();
        }
    }
}
