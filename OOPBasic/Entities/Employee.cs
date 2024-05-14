using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic.Entities
{
    public class Employee : IEmployee
    {

        public void AddEmployee(string EmployeeName)
        {
            Console.WriteLine($"Employee Name : {EmployeeName}");
        }
           
    }
}
