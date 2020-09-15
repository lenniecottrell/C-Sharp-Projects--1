using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabase
{
    public class Employee : Person, IQuittable //inherits from the person class and the IQuittable interface
    {
        public int EmpId { get; set; }

        public override void SayName() //implementing the say name method
        {
            throw new NotImplementedException();
        }
        public void Quit()
        {
            Console.WriteLine("Fuck you, fuck you, fuck you... you're cool... fuck you I'M OUT!"); //Quote from Half Baked :p
        }
        public static bool operator ==(Employee employee, Employee employee2)
        {
            return (employee.EmpId == employee2.EmpId);
        }
        public static bool operator !=(Employee employee, Employee employee2)
        {
            return !(employee.EmpId == employee2.EmpId);
        }
    }
}
