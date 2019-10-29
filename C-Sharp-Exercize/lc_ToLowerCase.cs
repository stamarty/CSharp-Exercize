using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercize
{
    /*  Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.

        Example 1:

        Input: "Hello"
        Output: "hello"
        Example 2:

        Input: "here"
        Output: "here"
        Example 3:

        Input: "LOVELY"
        Output: "lovely"
    */
    
    class lc_ToLowerCase
    {
        //uses the built in method "ToLower". Probably need to figure out how to do it without that. 
        public string ToLowerCase(string str)
        {
            string loweredString = str.ToLower();
            Console.WriteLine("your lowered string is: " + loweredString);
            return loweredString;
        }
    }
}
