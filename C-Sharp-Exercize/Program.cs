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
            lc_ToLowerCase loweredString = new lc_ToLowerCase();
            loweredString.ToLowerCaseSB("HERE IS A STRING IN UPPER CASE !");
            //test data from leetcode
            Console.WriteLine(loweredString.ToLowerCaseSB("Hello"));
            Console.WriteLine(loweredString.ToLowerCaseSB("here"));
            Console.WriteLine(loweredString.ToLowerCaseSB("LOVELY"));
        }
    }
}
