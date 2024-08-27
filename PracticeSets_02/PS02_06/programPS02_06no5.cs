using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_06_II.no5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for(i = 0; i < 3; i++)
            {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
        
            Console.WriteLine("The length of the word string is: " + word.Length);
            }
        }
    }
}