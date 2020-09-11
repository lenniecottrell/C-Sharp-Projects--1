using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step219
{
    public class DoSomeMath
    {
        public static int TimesFive(int inputNum)
        {
            return inputNum * 5;
        }
        public static decimal TimesFive(decimal inputNum)
        {
            return (int) inputNum * 50;
        }
        public static int TimesFive(string inputString)
        {
            bool success = Int32.TryParse(inputString, out int value);
            if (success == true)
            {
                return value + 14;
            }
            else if (value == 0)
            {
                Console.WriteLine("Sorry, I can't do math with that number. Try " + value);
                return value;
            }
            else
            {
                Console.WriteLine("You did a bad job");
                return value;
            }
        }
    }
}
