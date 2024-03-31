using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Welcome to Department...");
                Console.WriteLine("Please Choose...");
                Console.WriteLine("1. ADD Employee...");
                Console.WriteLine("2.See All of Them (Employees)...");
                Console.WriteLine("0. The End.");
                string input = Console.ReadLine();
                Department department=new Department();
                switch (input)
                {
                    case "1":
                        Employee employee = CreateEmployee();
                        department.AddEmployee(employee);
                        Console.WriteLine("Enter an Employee");
                        break;

                        case "2":
                        department.GetAllEmployees();
                        break;

                    case "0":
                        exit = true;
                        Console.WriteLine("The End");
                        break;

                    default:
                        Console.WriteLine("Choose right Number");
                        break;
                }
            }while (exit!=true);
        }
        public static Employee CreateEmployee()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter the Employee's Name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Enter the Employee's Surname");
            employee.Surname = Console.ReadLine();
            Console.WriteLine("Enter the Employee's Age");
            employee.Age= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Employee's Salary");
            employee.Salary= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Employee's DepartmentName");
            employee.DepartmentName = Console.ReadLine();

            return employee;

        }
        
    }
}
