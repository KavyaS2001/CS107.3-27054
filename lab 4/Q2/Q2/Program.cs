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
            Console.WriteLine("enter the radius");
            int radius = int.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine("area: " + area);
            Console.WriteLine("circumference: " + circumference);
            Console.ReadLine();
        }
    }
}
