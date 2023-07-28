using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
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
            int sub = num1 - num2;
            int multi = num1 * num2;
            int divi = num1 / num2;
            Console.WriteLine("summation is " + sum);
            Console.WriteLine("subtraction is " + sub);
            Console.WriteLine("multiplication is " + multi);
            Console.WriteLine("division is " + divi);
            Console.ReadLine();
        }
    }
}
