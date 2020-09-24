using System;
using System.IO;

namespace Page_290
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\lenni\Desktop\logs\numLog.txt", true))
            {
                file.WriteLine(input);
            }
            string output = File.ReadAllText(@"C:\Users\lenni\Desktop\logs\numLog.txt");
            Console.WriteLine("LOL you picked " + output);
            Console.Read();
        }
    }
}
