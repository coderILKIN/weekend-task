using ConsoleApp24.Custame;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class Department
    {
        public string Name { get; set; }

        public int EmployeeLimit { get; set; }

        public Department(string name,int employeelimit)
        {
            Name = name;
            EmployeeLimit = employeelimit;
        }



        public EmPloyee[] Employees = new EmPloyee[0];


        public void AddEmployee(EmPloyee emPloyee)
        {
           
            
                if (EmployeeLimit >= Employees.Length+1)
                {
                    Array.Resize(ref Employees, Employees.Length + 1);
                    Employees[Employees.Length - 1] = emPloyee;
                }
                else
                {
                    throw new CapacityLimitException("limit doldu");
                }
            
            
        }

        public EmPloyee this[int i]
        {
            get { return Employees[i]; }
            set { Employees[i] = value; }
        }




    }
}
