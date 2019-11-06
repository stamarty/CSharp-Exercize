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


            string J = "aA";
            string S = "aaAAbbbBBb";

            lc_JewelsAndStones jewels = new lc_JewelsAndStones();
            Console.WriteLine(jewels.NumJewelsInStones(J, S));
        }
    }
}
