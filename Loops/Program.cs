using System;


namespace Loops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Here are your options: \n\ttomatos \n\tpotatos \n\tdoritos \n\ttostitos");
            Console.WriteLine("Pick one!");
            string homophone = Console.ReadLine();
            string lc = homophone.ToLower();

            do
            {
                Console.WriteLine("You picked " + homophone + ", now...");
                Console.WriteLine("Pick the most flavorblasted one!");
                homophone = Console.ReadLine();
                lc = homophone.ToLower();
            }
            while (lc != "doritos");

            Console.WriteLine("You betcha!");
            Console.ReadLine();
        }
    }
}
