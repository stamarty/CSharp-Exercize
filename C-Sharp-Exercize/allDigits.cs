using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercize
{
    
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            Console.WriteLine(test.allDigits("here is a string with no digits"));
            Console.WriteLine(test.allDigits("1111111"));

        }
    */

        // 
        // Student: Steven Martinez
        // 
        // Genesis: Question was asked during a practice whiteboarding session from Microsoft Mentors 
        // Summary: Checks a string to see if the value of the string is all digits. Returns false if there is a letter in there.
        // returns bool
        public bool allDigits(string s)
        {
            //using try/catch to return false if error during parse.
            try
            {
                foreach (char c in s)
                {
                    int.Parse(c.ToString());
                }
            }

            catch (Exception)
            {
                return false;
            }

            return true;
        }

        // Output:
        // False
        // True

    }
}
