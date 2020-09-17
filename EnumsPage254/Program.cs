using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsPage254
{
    class Program
    {
        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main()
        {
            Console.WriteLine("Please enter the current day of the week: ");
            string input = Console.ReadLine();
            DaysOfTheWeek day;
            try
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                Console.WriteLine("If you say so! Today is " + day);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("WARNING!!! EXTREME FAILURE!! COMPUTER WILL SELF-DESTRUCT IN 10 SECONDS....");
                Console.WriteLine("Please enter an actual day of the week (with proper capitalization please).");
                Console.WriteLine(ex.Message);
                day = DaysOfTheWeek.Monday;
                Console.ReadLine();
            }
        }            

    }
}
