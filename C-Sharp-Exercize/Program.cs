using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercize
{
    class Program
    {
        static void Main(string[] args)
        {
            lc_DefangIP defang = new lc_DefangIP();

            Console.WriteLine(defang.DefangIPaddr("1.1.1.1"));
        }
    }
}
