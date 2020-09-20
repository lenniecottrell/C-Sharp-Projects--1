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
            Employee employee3 = new Employee() { FirstName = "Todd", LastName = "Toddington", EmpId = 103 };

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
            //Number num = new Number();
            //num.Amount = 29.99M;
            //Console.WriteLine(num.Amount);
            //Console.ReadLine();

            //For P. 265

            Employee employee4 = new Employee() { FirstName = "Sam", LastName = "Samington", EmpId = 104 }; //same ID as employee1 to test the overloaded == operator
            Employee employee5 = new Employee() { FirstName = "Barb", LastName = "Barbington", EmpId = 105 }; //same ID as employee1 to test the overloaded == operator
            Employee employee6 = new Employee() { FirstName = "Joe", LastName = "Joeington", EmpId = 106 }; //same ID as employee1 to test the overloaded == operator
            Employee employee7 = new Employee() { FirstName = "Tina", LastName = "Tinaington", EmpId = 107 }; //same ID as employee1 to test the overloaded == operator
            Employee employee8 = new Employee() { FirstName = "Sally", LastName = "Sallyington", EmpId = 108 }; //same ID as employee1 to test the overloaded == operator
            Employee employee9 = new Employee() { FirstName = "Joe", LastName = "OtherJoe", EmpId = 109 }; //same ID as employee1 to test the overloaded == operator
            Employee employee10 = new Employee() { FirstName = "Steven", LastName = "Stevenington", EmpId = 110 }; //same ID as employee1 to test the overloaded == operator
            List<Employee> employees = new List<Employee>()
            {
                employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10
            };

            List<Employee> joes = employees.Where(x => x.FirstName == "Joe").ToList(); //lambda function that adds the joes to a new list
            List<Employee> greaterThan5 = employees.Where(x => x.EmpId > 105).ToList();
            ////foreach to add the joes to the new list
            //foreach (Employee worker in employees)
            //{
            //    if (worker.FirstName == "Joe")
            //    {
            //        joes.Add(worker);
            //    }
            //}
            Console.WriteLine(joes.Count());
            Console.WriteLine(greaterThan5.Count());
            Console.ReadLine();


        }
    }
}
