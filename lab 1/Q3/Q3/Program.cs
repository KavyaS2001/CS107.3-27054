using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("enter the number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number: ");
            num2 = int.Parse(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine("summation is " + sum);
            Console.ReadLine();
        }
    }
}
