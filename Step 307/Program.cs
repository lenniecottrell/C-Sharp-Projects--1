using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_307
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello. How old are you? Please enter an integer");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new NegException();
                }

                DateTime now = DateTime.Now;
                int thisYear = now.Year;

                int birthYear = thisYear - age;
                Console.WriteLine("You were born in the year " + birthYear);
                Console.ReadLine();
            }

            catch (NegException)
            {
                Console.WriteLine("You are a dirty liar! Goodbye!");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. It's probably your fault.");
                Console.Read();
                return;
            }



        }
    }
}
