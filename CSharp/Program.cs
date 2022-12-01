using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp
{
    public class Program
    {

        public static void Main()
        {
            IList<Employee> employees = new List<Employee>()
            {
                new Employee {Name = "omar", Id = 101, Salary = 5000, Experience = 5},
                new Employee {Name = "Khalid", Id = 102, Salary = 4000, Experience = 4},
                new Employee {Name = "Ali", Id = 103, Salary = 7000, Experience = 6},
                new Employee {Name = "Han", Id = 104, Salary = 5000, Experience = 2}
            };

            Employee.PromoteEmployee(employees);

        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public int Experience { get; set; }

            public static void PromoteEmployee(IList<Employee> employees)
            {
                foreach (var employee in employees)
                {
                    if (employee.Experience >= 5)
                        Console.WriteLine(employee.Name + " Promoted");
                }

            }
        }
    }
}
