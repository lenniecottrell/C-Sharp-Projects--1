using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to do some math: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number plus ten is " + Math.addTen(inputNum));
            Console.WriteLine("Your number times ten is " + Math.timesTen(inputNum));
            Console.WriteLine("Your number minus ten is " + Math.minusTen(inputNum));
            Console.ReadLine();
        }
    }
}
