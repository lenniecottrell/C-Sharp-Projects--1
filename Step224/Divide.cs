using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step224
{
    static class Divide //static class
    {
        public static void By2(int input)
        {
            int output = input / 2;
            Console.WriteLine(output);
        }

        public static void By2(int input, int input2) //overloaded method
        {
            int output = input / input2;
            Console.WriteLine(output);
        }

        public static void OutputTrial(out int num2) //output parameters 
        {
            int num1 = 5;
            num2 = num1;
            Console.WriteLine("Abracadabra! Now your number is " + num2);
        }

    }
}
