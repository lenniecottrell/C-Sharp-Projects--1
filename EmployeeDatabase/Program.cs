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
            Employee employee1 = new Employee() { FirstName = "sample", LastName = "student", EmpId = 101 }; //new employee object
            Employee employee2 = new Employee() { FirstName = "Bob", LastName = "Bobbington", EmpId = 102 };
            Employee employee3 = new Employee() { FirstName = "Todd", LastName = "Toddington", EmpId = 101 }; //same ID as employee1 to test the overloaded == operator

            IQuittable employee4 = employee2; //creating a new object of type IQuittable
            employee4.Quit(); //calling the Quit() method on the new object
            Console.ReadLine();


            Console.WriteLine(employee1 == employee3); //this is the desired outcome of overloading the operator
            Console.ReadLine();
        }
    }
}
