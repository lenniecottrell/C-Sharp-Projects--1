using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists2
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Bob", "Sandra", "Iris", "Diego", "Ingrid", "Marco" };

            Console.WriteLine("Select a name by entering a number between 0 and 5:");
            try
            {
            int nameInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You selected " + names[nameInt]);
            Console.ReadLine();
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid Selection");
            }

            int[] nums = { 3, 7, 10, 54, 4997, 20, 4, 1 };


            Console.WriteLine("Select a number by entering a number between 0 and 7:");
            try
            {
                int numsInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You selected the number " + nums[numsInt]);
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid Selection");
                Console.ReadLine();
            }

            List<string> bunchaStrings = new List<string>();
            bunchaStrings.Add("Portland");
            bunchaStrings.Add("Chicago");
            bunchaStrings.Add("Dallas");
            bunchaStrings.Add("Seattle");
            bunchaStrings.Add("Santa Fe");
            bunchaStrings.Add("Cincinnati");
            bunchaStrings.Add("Nashville");

            Console.WriteLine("Select a City by entering a number between 0 and 6:");
            int cityInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You selected " + bunchaStrings[cityInt]);
            Console.ReadLine();
        }
    }
}
