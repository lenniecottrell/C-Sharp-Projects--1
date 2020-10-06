using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 5, 10, 13, 16, 17, 400, 365, 27, 94, 289 };
            Console.WriteLine("Please pick a number to be the divisor");

            try
            {
                int devisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                foreach (int num in numList)
                {
                    int result = num / devisor;
                    Console.WriteLine(result);
                }
                    Console.WriteLine("Math was successful!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("You were unable to follow directions, and an error has occurred.");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Something weird happened! Who knows what with these dang computers, you know?");
                Console.WriteLine("Continuing program...");
            }
            Console.ReadLine();
        }
    }
}
