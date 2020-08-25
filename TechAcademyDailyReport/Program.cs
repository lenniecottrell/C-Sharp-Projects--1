using System;


namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            int coursePage = Convert.ToInt32(pageNum);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\": ");
            string needHelp = Console.ReadLine();
            bool helpBool = Convert.ToBoolean(needHelp);
            Console.WriteLine("Where there any positive or negative experiences you'd like to share? Please give specifics: ");
            string goodTimes = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific: ");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?: ");
            string studyTime = Console.ReadLine();
            int studyHours = Convert.ToInt32(studyTime);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
