﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step237
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //new employee object
        //    employee.SayName(); //calling the method on the new object
        //}
        {
            IQuittable employee = new Employee(); //creating a new object of type IQuittable
            employee.Quit(); //calling the Quit() method on the new object
        }
    }
}
