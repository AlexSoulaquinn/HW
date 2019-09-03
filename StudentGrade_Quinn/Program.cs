using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade_Quinn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alex Quinn
            //Declare variables
            const double quizWeight = .001;
            const double participationWeight = .001;
            const double homeworkWeight = .0025;
            const double midtermWeight = .0025;
            const double finalWeight = .003;
            string firstName, lastName, studentID, quizGrade, participationGrade, hwGrade, midtermGrade, finalExamGrade, finalGradeAsString;
            double quizPercent, participationPercent, hwPercent, midtermPercent, finalExamPercent, finalGrade;

            //Prompt user to enter first name, last name, student ID #, and overall % grade for quizzes, participation, HWs, midterm, and final exam
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("What is your student ID?");
            studentID = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for homework?");
            hwGrade = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for participation?");
            participationGrade = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            quizGrade = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the midterm?");
            midtermGrade = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the final?");
            finalExamGrade = Console.ReadLine();

            //Convert strings to doubles
            hwPercent = Convert.ToDouble(hwGrade);
            participationPercent = Convert.ToDouble(participationGrade);
            quizPercent = Convert.ToDouble(quizGrade);
            midtermPercent = Convert.ToDouble(quizGrade);
            finalExamPercent = Convert.ToDouble(finalExamGrade);

            //Calculate final grade as a percent
            finalGrade = (hwPercent * homeworkWeight) + (participationPercent * participationWeight) + (quizPercent * quizWeight) + (midtermPercent * midtermWeight) + (finalExamPercent * finalWeight);

            //convert necessary doubles to strings
            finalGradeAsString = finalGrade.ToString("P2");

            //Output to user
            Console.WriteLine(firstName + " " + lastName + " " + "(" + studentID + ")" + ", your final grade is " + finalGradeAsString);
            Console.ReadKey();
        }
    }
}
