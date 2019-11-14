using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercize
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        lc_ToLowerCase test = new lc_ToLowerCase();

    //        Console.WriteLine(test.ToLowerCaseSB("Hello"));
    //        // below should return same string
    //        Console.WriteLine(test.ToLowerCaseSB("here"));
    //        Console.WriteLine(test.ToLowerCaseSB("LOVELY"));

    //    }
    //}

    class lc_ToLowerCase
    {
        // Student: Steven Martinez
        //
        // Genesis: This problem is in Leetcode.com
        //
        // Summary: Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.
        //
      


        // This method uses the built in method "ToLower". Probably need to figure out how to do it without that.
        // I'm going to leave this here for education's sake. The above samples use the second method in this class
        public string ToLowerCase(string str)
        {
            string loweredString = str.ToLower();
            Console.WriteLine("your lowered string is: " + loweredString);
            return loweredString;
        }

        
        // This method takes the ascii value of the character, checks if it is in range
        // between 65 and 90. If so the letter is capital and the method will add 32 to the 
        // ascii character to go from upper to lowercase. 
        public string ToLowerCaseSB(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
			{
                // is the character capital?
                if (str[i] > 64 && str[i] <= 90)
                {
                    // add 32 to make it lowercase
                    stringBuilder.Append((char)((int) str[i] + 32));
                }

                else
                {
                    stringBuilder.Append(str[i]);
                }
            }
            
            return stringBuilder.ToString();
        }
    }

    // Output: 
    // hello
    // here
    // lovely
}
