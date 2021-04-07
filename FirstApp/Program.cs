using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New Line Added");
            Console.WriteLine("Hello World!");
            Employee e1 = new Employee();
            e1.Empname = "Radha";
            e1.Salary = 50000;
            Employee e2 = new Employee("Vandhana", 230000);
            Console.WriteLine(e1.Empname + "  " + e1.Salary);
            Console.WriteLine(e2.Empname + " " + e2.Salary);
            Console.ReadLine();
        }
    }
}
