using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public void PrintEmployeeList(List<Employee> empList)
        {
            foreach (Employee emp in empList)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.Salary}");
            }
        }
    }
}
