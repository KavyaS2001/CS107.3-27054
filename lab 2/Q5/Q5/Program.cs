using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine("enter the numbers :");
                int number = int.Parse(Console.ReadLine());

                if(number % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }
            }
            Console.ReadLine();
        }
    }
}
