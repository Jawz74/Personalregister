using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal static class StaffManager
    {
        public static void PrintEmployeeList(List<Employee> empList)
        {
            int counter = 1;
            foreach (Employee emp in empList)
            {
                Console.WriteLine($"{counter}. {emp.FirstName} {emp.LastName} {emp.Salary}");
                counter++;
            }
        }
    }
}
