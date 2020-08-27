using System;


namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person1 \nHourly Rate: ");
            string person1hourly = Console.ReadLine();
            float hourlyRateP1 = float.Parse(person1hourly);

            Console.WriteLine("Hours worked per week: ");
            string person1hours = Console.ReadLine();
            float hoursWorkedP1 = float.Parse(person1hours);

            float annualSalaryP1 = (hourlyRateP1 * hoursWorkedP1) * 52;
            string salaryString1 = Convert.ToString(annualSalaryP1);
            

            Console.WriteLine("Person2 \nHourly Rate: ");
            string person2hourly = Console.ReadLine();
            float hourlyRateP2 = float.Parse(person2hourly);

            Console.WriteLine("Hours worked per week: ");
            string person2hours = Console.ReadLine();
            float hoursWorkedP2 = float.Parse(person2hours);

            float annualSalaryP2 = (hourlyRateP2 * hoursWorkedP2) * 52;
            string salaryString2 = Convert.ToString(annualSalaryP2);


            Console.WriteLine("The annual salary of Person 1:\n" + salaryString1 + "\n");
            Console.WriteLine("The annual salary of Person 2:\n" + salaryString2 + "\n");

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moreMoney = annualSalaryP1 > annualSalaryP2;
            Console.WriteLine(moreMoney);
            Console.Read();
        }
    }
}
