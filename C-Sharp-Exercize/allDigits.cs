using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercize
{
    class allDigits
    {
        // checks a string to see if the value of the string is all digits. Returns false if there is a letter in there.
        public bool AllDigits(string s)
        {
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
    }
}
