using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            // #1
            Console.WriteLine("Pick a number!: ");
            string userNum = Console.ReadLine();
            decimal number = Convert.ToInt32(userNum);
            decimal timesFifty = number * 50;
            Console.WriteLine("Your number times fifty is " + timesFifty);

            // #2
            Console.WriteLine("Pick another number!: ");
            string userNum2 = Console.ReadLine();
            float number2 = Convert.ToInt32(userNum2);
            float addtwentyfive = number2 + 25;
            Console.WriteLine("Your number plus 25 is " + addtwentyfive);

            // #3
            Console.WriteLine("Pick another number!: ");
            string userNum3 = Console.ReadLine();
            float number3 = Convert.ToInt32(userNum3);
            double divideBy = number3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + divideBy);

            // #4
            Console.WriteLine("Pick another number!: ");
            string userNum4 = Console.ReadLine();
            float number4 = Convert.ToInt32(userNum4);
            bool isGreaterThan = number4 > 50;
            Console.WriteLine(isGreaterThan);


            // #5
            Console.WriteLine("Pick another number!: ");
            string userNum5 = Console.ReadLine();
            float number5 = Convert.ToInt32(userNum5);
            float modulus7 = number5 % 7;
            Console.WriteLine("When your number is divided by 7, the remainder is " + modulus7);
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();


            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five equals " + difference);
            //Console.ReadLine();


        }
    }
}
