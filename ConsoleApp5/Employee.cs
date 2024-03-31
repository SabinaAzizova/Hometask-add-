using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        public string DepartmentName;

        private double _age;
        public double Age
       
        {
            get
            {
                return Age;
            }
            set
            {
                if(Age>0)
                {
                    Age = value;
                }
            }
        }
        private double _salary;
        public double Salary
      
        {
            get
            {
                return _salary;
            }
            set
            {
                if (Salary>0)
                {
                    _salary = value;
                }
            }
        }
        public Employee() { }
        public Employee(string name, string surname, double age,double salary)
        {
            Name = Name;
            Surname = Surname;
            Age = Age;
            Salary = Salary;
            DepartmentName = DepartmentName;

        }

    }
}
