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
            int x = 1;
            while(x < 5)
            {
                Console.WriteLine ("Enter the 1st number:");
                int num = Convert.ToInt32(Console.ReadLine());
        
                Console.WriteLine ("Enter the 2nd number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
        
                int sum = num + num2;
                Console.WriteLine(sum);
            }
        }
    }
}
