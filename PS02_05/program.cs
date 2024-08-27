using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Enter a Letter:");
        
        string user = Console.ReadLine();
        
        if (user == "a" || user == "e" || user == "i" || user == "o" || user == "u") {
            Console.WriteLine ($"The Letter {user} is a vowel");
        }
        
        else {
            Console.WriteLine ($"The Letter {user} is a consonant");
        }

        }
    }
}
