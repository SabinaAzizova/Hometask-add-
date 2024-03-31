using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Department
    {
        public string Name;
        Employee[] Employees;

        public Department()
        {
            Employees = new Employee[0];
        }
        public void AddEmployee(Employee employee)
        {
            Employee[] newEmployees = new Employee[Employees.Length + 1];

            for (int i = 0; i < Employees.Length; i++)
            {
                newEmployees[i] = Employees[i];
            }
            newEmployees[newEmployees.Length - 1] = employee;
            Employees= newEmployees;
        }
        public void ShowEmployeeInfo()
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine($" Name: {employee.Name}, Surname:{employee.Surname}, Age:{employee.Age}");
            }
        }
        public void GetAllEmployees()
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine($" Name:{employee.Name}, Surname:{employee.Surname}, Age:{employee.Age}");
            }
        }
    }
}
