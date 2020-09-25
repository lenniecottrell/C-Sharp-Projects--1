using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_303
{
    class Program
    {
        static void Main(string[] args)
        {
            const int daysOfTheYear = 365;
            var daysICelebrateMyBirthday = 14;

            Console.WriteLine("There are " + daysOfTheYear + " days in the year but there are at least " + daysICelebrateMyBirthday + " of them I celebrate my birthday. Why keep it to just one day?");
            Console.ReadLine();

            meal breakfast = new meal("Cake");
            Console.WriteLine("For bday breakfast I have " + breakfast.mainCourse + " and " + breakfast.Drink);

            Console.ReadLine();
        }
    }
}
