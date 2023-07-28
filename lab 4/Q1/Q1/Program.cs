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
            Console.WriteLine("enter the KM value: ");
            double km = double.Parse(Console.ReadLine());

            ConvertValues obj = new ConvertValues();
            obj.kilometerTOmeter(km);

            Console.ReadKey();
        }
    }
}
