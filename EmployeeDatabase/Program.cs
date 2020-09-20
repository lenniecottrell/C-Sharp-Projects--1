using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee<Person> employee1 = new Employee<Person>() { FirstName = "sample", LastName = "student", EmpId = 101 }; //new employee object
            //Employee<Person> employee2 = new Employee<Person>() { FirstName = "Bob", LastName = "Bobbington", EmpId = 102 };
            //Employee<Person> employee3 = new Employee<Person>() { FirstName = "Todd", LastName = "Toddington", EmpId = 101 }; //same ID as employee1 to test the overloaded == operator

            //IQuittable employee4 = employee2; //creating a new object of type IQuittable
            //employee4.Quit(); //calling the Quit() method on the new object
            //Console.ReadLine();


            //Console.WriteLine(employee1 == employee3); //this is the desired outcome of overloading the operator
            //Console.ReadLine();

            //Employee<string> employee5 = new Employee<string>();
            //employee5.Things = new List<string> { "Latte", "Wallet", "Cell phone", "Bike", "Arachnophobia" };
            //Employee<int> employee6 = new Employee<int>();
            //employee6.Things = new List<int> { 1, 2, 3, 4, 5, 6 };

            //Console.WriteLine("Employee 5's things:");

            //foreach (string thing in employee5.Things)
            //{
            //    Console.WriteLine(thing);
            //}
            //Console.WriteLine("\nEmployee 6's things:");

            //foreach (int thing in employee6.Things)
            //{
            //    Console.WriteLine(thing);
            //}
            //Console.ReadLine();

            //For p. 260
            Number num = new Number();
            num.Amount = 29.99M;
            Console.WriteLine(num.Amount);
            Console.ReadLine();

        }
    }
}
