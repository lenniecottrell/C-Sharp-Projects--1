using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step224
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide.By2(10); //since the Divide class is static, we can access the methods without instantiating an object of the class

            Console.WriteLine("Please enter a number: "); //ask for input
            int input = Convert.ToInt32(Console.ReadLine());
            Divide.By2(input); //display the output using the method
            Console.ReadLine();

            Console.WriteLine("Please enter another number: ");
            int anotherNumber = Convert.ToInt32(Console.ReadLine());

            Divide.OutputTrial(out anotherNumber);
            Console.ReadLine();


        }
    }
}
