using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemp = 80;
            int roomTemp = 70;

            string comparisonResult = currentTemp == roomTemp ? "It is room temp" : "It is not room temp";

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It's some other temperature");
            //}
            Console.ReadLine();
        }
    }
}
