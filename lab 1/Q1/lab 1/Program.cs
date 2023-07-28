using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string batch;
            Console.WriteLine("enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("enter your batch");
            batch =Console.ReadLine();
            Console.WriteLine("My name is "+name);
            Console.WriteLine("My batch is "+ batch);
            Console.ReadLine();
        }
    }
}
