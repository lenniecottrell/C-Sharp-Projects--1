using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Please enter the package width");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length");
            int pkgLength = Convert.ToInt32(Console.ReadLine());
            if ((pkgWidth + pkgLength + pkgHeight) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            float calcQuote = ((pkgHeight * pkgLength * pkgWidth) * pkgWeight) / 100;
            string quote = calcQuote.ToString();
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00\nThank You!");
            Console.ReadLine();

        }
    }
}
