using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = num; i > 0; i /= 10)
            {
                int digit = i% 10;
                sum += digit;
            }
            Console.WriteLine("sum of digits: "+sum);
            Console.ReadLine();
        }
    }
}
