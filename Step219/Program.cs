using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step219
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number times five is " + DoSomeMath.TimesFive(inputNum));
            Console.ReadLine();

            Console.WriteLine("Please enter a decimal number:");
            decimal inputNum2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Your number times 50 as an integer is " + DoSomeMath.TimesFive(inputNum2));
            Console.ReadLine();

            Console.WriteLine("Please enter one more number");
            string inputString = Console.ReadLine();
            Console.WriteLine("Your number plus 14 is " + DoSomeMath.TimesFive(inputString));
            Console.ReadLine();


        }
    }
}
