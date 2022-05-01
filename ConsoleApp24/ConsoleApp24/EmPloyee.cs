using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class EmPloyee : IPerson
    {
        private static int _id;
        public int Id { get;}

        

        public int Salary { get; set;}


        public EmPloyee(string name,int salary,int age)
        {
            Id = ++_id;
            Name = name;
            Age = age;
            Salary = salary;
        }




        public string Name { get; set; }
        public int Age { get; set; }

        public string ShowInfo()
        {
            return $"Id: {Id}, Salary: {Salary}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
