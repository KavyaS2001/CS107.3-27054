using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("summation is " + sum);
            Console.ReadLine();
        }
    }
}
