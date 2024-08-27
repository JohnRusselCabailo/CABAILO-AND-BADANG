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
            int[] num = { 1, 2, 3 };
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
                Console.WriteLine(sum);
        }
    }
}