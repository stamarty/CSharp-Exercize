using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercize
{
    // Given a valid(IPv4) IP address, return a defanged version of that IP address.
    // A defanged IP address replaces every period "." with "[.]".
    
    public class lc_DefangIP
    { 
        public string DefangIPaddr(string address)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in address)
            {
                if (c.ToString() == ".")
                {
                    sb.Append("[.]");
                }

                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
