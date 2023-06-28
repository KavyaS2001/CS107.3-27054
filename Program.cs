using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Practicle__Arrays_
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            /*
            // Summation Linear numbers  array...

            int[] numbers = new int[10];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Numbers :");
                numbers[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine("SUM :"+sum);
            Console.ReadLine();*/

            /*
            // Finding the Min and Max value of the array
            int[] val = new int[10];
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter 10 numbers: ");
                val[i] = int.Parse(Console.ReadLine());

                if (val[i] < min)
                {
                    min = val[i];
                }

                if (val[i] > max)
                {
                    max = val[i];
                }
            }

            Console.WriteLine("MIN: " + min);
            Console.WriteLine("MAX: " + max);

            Console.ReadLine();


            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Enter 10 numbers :" + val[i]);
                val[i] = int.Parse(Console.ReadLine());
          
                    if (val[i] < min)
                    {
                        min = val[i];

                    }
                    else
                    {
                        max = val[i];
                    }
                
            }


            Console.WriteLine("MIN" + min);
            Console.WriteLine("MAX" + max);




            Console.ReadLine();*/

            /*
            //Implimentation of Bubble sort algorythem.
            int[] num = { 122, 45, 65, 56, 49, 326, 15, 45, 945, 153 };

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }

            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i] + " ");
                Console.Readline();*/

            //2D Array.
            int[,] num = { { 10, 20 }, { 23, 43 } };

            int min = num[0, 0];
            int max = num[0, 0];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (num[i, j] < min)
                    {
                        min = num[i, j];
                    }

                    if (num[i, j] > max)
                    {
                        max = num[i, j];
                    }
                }
            }
            Console.WriteLine("Min :" + min);
            Console.WriteLine("Max :" + max);
            Console.Readline();







        }

    }
    
}
