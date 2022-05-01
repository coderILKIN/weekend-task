using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            EmPloyee emPloyee = new EmPloyee("ILKIN",2000,21);
            EmPloyee emPloyee2 = new EmPloyee("ILKIN", 1000, 20);
            EmPloyee emPloyee3 = new EmPloyee("ILKIN", 3000, 23);
            EmPloyee emPloyee4 = new EmPloyee("ILKIN", 5000, 25);
            Department department = new Department("1ci",3);

            department.AddEmployee(emPloyee);
            department.AddEmployee(emPloyee2);
            department.AddEmployee(emPloyee3);
            department.AddEmployee(emPloyee4);


            foreach (var item in department.Employees)
            {
                Console.WriteLine($"Name: {item.Name}");
            }
            Console.WriteLine(department[0]);
            Console.WriteLine(department[1]);
            Console.WriteLine(department[2]);
        }
    }
}
