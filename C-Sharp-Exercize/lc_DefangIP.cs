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
    //        lc_DefangIP test = new lc_DefangIP();

    //        Console.WriteLine(test.DefangIPaddr("123.23.12.156"));


    //    }
    //}


    public class lc_DefangIP
    {
        // 
        // Student: Steven Martinez
        //
        // Genesis: Code problem is from leetcode.com
        //
        // Summary: Given a valid(IPv4) IP address, return a defanged version of that IP address.
        // A defanged IP address replaces every period "." with "[.]".
        // This solution does not check that the ip is a valid address. It only replaces periods with [.]. 
        public string DefangIPaddr(string address)
        {
            // create a new stringbuilder object
            StringBuilder sb = new StringBuilder();

            // loop through the array check each character
            foreach (char c in address)
            {
                // if the char is a period "." replace it in the stringbuilder with "[.]"
                if (c.ToString() == ".")
                {
                    sb.Append("[.]");
                }

                // for any other character just build the string. 
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }

    // Output - 
    // 123[.]23[.]12[.]156
}
