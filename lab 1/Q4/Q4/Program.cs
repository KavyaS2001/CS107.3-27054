using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salary;
            double taxrate;
            Console.WriteLine("enter the salary: ");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the tax rate: ");
            taxrate = double.Parse(Console.ReadLine());
            double newsalary = salary - (salary * taxrate/100);
            Console.WriteLine("your new salary is " + newsalary);
            Console.ReadLine();

        }
    }
}
