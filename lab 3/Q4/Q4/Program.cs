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
            Console.WriteLine("Enter a positive number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 1; i <= num; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("sum of all odd numbers: " + sum);
            Console.ReadLine();


        }
    }
}
