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
            loweredString.ToLowerCase("HERE IS A STRING IN UPPER CASE !");
            //test data from leetcode
            loweredString.ToLowerCase("Hello");
            loweredString.ToLowerCase("here");
            loweredString.ToLowerCase("LOVELY");
        }
    }
}
