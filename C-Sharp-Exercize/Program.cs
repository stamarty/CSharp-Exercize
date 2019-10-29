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
            cci_ReverseString words = new cci_ReverseString();
            words.ReverseString("Steven Martinez is my son!");
            words.PrintReverseString("This string will be written to the console");
            words.PrintReverseString("Cierra Michelle is my daughter....but not my favorite one.");
        }
    }
}
