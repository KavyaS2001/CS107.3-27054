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
            int radius;
            Console.WriteLine("enter the radius: ");
            radius = int.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("the are of the circle is " + area);
            Console.ReadLine();
        }
    }
}
