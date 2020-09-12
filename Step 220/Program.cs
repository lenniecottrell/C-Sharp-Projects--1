using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_220
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoSomeMath.TwoNums(3, 5)); //instantiate the class
            Console.WriteLine("Please enter a number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number, if you feel like it: ");
            try
            {
                int input2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your first number times your second number (if you felt like it) plus 10 equals " + DoSomeMath.TwoNums(input1, input2));
            }
            catch (FormatException)
            {
                Console.WriteLine("You didn't feel like putting in that second number, and ya know? That's okay!");
                Console.WriteLine("Your first number plus 10 equals " + DoSomeMath.TwoNums(input1));
            }
            Console.ReadLine();
        }
    }
}
