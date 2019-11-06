using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercize
{
    // You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  
    // Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.
    //
    // The letters in J are guaranteed distinct, and all characters in J and S are letters.Letters are case sensitive, 
    // so "a" is considered a different type of stone from "A".
    class lc_JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            int counter = 0;
            char[] jewels = J.ToCharArray();

            for (int i = 0; i < S.Length; i++)
            {
                if (jewels.Contains(S[i]))
                {
                    counter++;
                }
            }
            
            return counter;
        }
    }
}
