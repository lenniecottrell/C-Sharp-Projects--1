using System;
using System.Net.Configuration;

namespace ConditionalStatements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pick a number between 1 and 50");
            string numStr = Console.ReadLine();
            float numInt = Convert.ToInt32(numStr);
            if (numInt > 25 && numInt != 42)
            {
                Console.WriteLine("your number is greater than 25");
                Console.ReadLine();
            }
            else if (numInt <= 5)
            {
                Console.WriteLine("Your number is 5 or less");
                Console.ReadLine();
            }
            else if (numInt == 42)
            {
                Console.WriteLine("Your number is the answer to life, the universe, and everything");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your number is " + numInt);
                Console.ReadLine();
            }

            Console.WriteLine("Pick another number less than 1000");
            string num2Str = Console.ReadLine();
            int num2Int = Convert.ToInt32(num2Str);

            string result = num2Int > 500 ? "You picked a number greater than 500" : "You picked a number less than 500";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
