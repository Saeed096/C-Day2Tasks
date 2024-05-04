using System.Data;

namespace ConsoleApp1
{

    [Flags]
    enum Role
    {
        Admin = 1,
        accountant = 2,
        Stock = 4,
        Reception = 8,
    }
   
    internal class Program
    {


        
        static void Main(string[] args)
        {
            manager m1 = new manager();      // ctrl k s to make a region
            Console.WriteLine(m1.ToString()); // implement employee to string not obj to string
            Console.WriteLine("Hello, World!");
            Employee e1 = new Employee();
            e1.role = Role.Stock | Role.Reception;         // why if role is here cannot work??????  it works anywhere but should be put outside the class so anywhere it is inside the same name space
            Console.WriteLine(e1.ToString());
            //  Console.WriteLine(e1.role);
            e1.displayData();
            e1.assignRole(Role.accountant | Role.Admin);
            e1.displayData();
            Console.WriteLine(e1.hasRole(Role.Stock));


        }

    }
}
