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
            Console.WriteLine("input the string: ");
            string word;
            word = Console.ReadLine();

            int vowel = 0;


            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i]=='A'||
                    word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i]=='U')
                {
                    vowel++;
                }
            }
            Console.WriteLine("\nthe total number of vowel: " + vowel);
            Console.ReadLine();
        }
    }
}
