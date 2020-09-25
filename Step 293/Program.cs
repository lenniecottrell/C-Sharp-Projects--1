using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_293
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("\nPlease enter a number: ");
            double hours = Convert.ToDouble(Console.ReadLine());

            DateTime now = DateTime.Now;
            DateTime hoursFromNow = now.AddHours(hours);
            Console.WriteLine("Right now it is " + now);
            Console.WriteLine("in " + hours + " hours it will be " + hoursFromNow);
            Console.ReadLine();

        }
    }
}
