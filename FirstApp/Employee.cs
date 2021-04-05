using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    class Employee
    {
        public string Empname { get; set; }
        public float Salary { get; set; }

        public Employee()
        {

        }
        public Employee(string ename, float sal)
        {
            Empname = ename;
            Salary = sal;
        }
    }
}
