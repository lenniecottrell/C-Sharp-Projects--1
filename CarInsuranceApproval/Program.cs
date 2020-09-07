using System;
using System.Runtime.InteropServices;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string ageStr = Console.ReadLine();
            int ageInt = Convert.ToInt32(ageStr);

            Console.WriteLine("Have you ever had a DUI? true/false");
            string DUIstatus = Console.ReadLine();
            bool DUIbool = Convert.ToBoolean(DUIstatus);

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsStr = Console.ReadLine();
            int ticketsInt = Convert.ToInt32(ticketsStr);

            Console.WriteLine("Qualified?");
            Console.WriteLine(ageInt > 15 && DUIbool == false && ticketsInt <= 3);
            Console.Read();


        }
    }
}
