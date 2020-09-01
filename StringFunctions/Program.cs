using System;
using System.Linq;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Lennie";
            string lname = "Cottrell";
            string city = "Portland";
            Console.WriteLine("Hello my name is " + fname + " " + lname + " and I live in " + city);

            city = city.ToUpper();
            Console.WriteLine("Did you hear me? I said I live in " + city);

            StringBuilder sb = new StringBuilder();
            sb.Append("Once upon a time, ");
            Console.WriteLine();
            Console.ReadLine();

            sb.Append("there was a scary dragon.");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Append(" One day, the scary dragon burned the village down.");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Append(" The end.");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
