using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Employee
    {
        public Employee()
        {
            this.name = "saeed";
            this.salary = 1000;
            this.role = Role.Admin;
        }
        public string name;
        public int salary;
        public Role role;

        public void displayData()
        {
            Console.WriteLine($"Employee name is {this.name} and salary is {this.salary} and role is {this.role}");
        }

        public void assignRole(Role r)
        {
            this.role = r;
        }

        public override string ToString()
        {
            return "This is employee";
        }

        public bool hasRole(Role r)
        {
            if ((this.role & r) == r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
