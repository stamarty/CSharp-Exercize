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
    //        lc_JewelsAndStones test = new lc_JewelsAndStones();

    //        Console.WriteLine(test.NumJewelsInStones("AaBc", "aaBBccAAddeeff"));

    //    }
    //}


    class lc_JewelsAndStones
    {
        // Student: Steven Martinez
        //
        // Genesis: This coding problem is from leetcode.com
        //
        // Summary: You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  
        // Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.
        //
        // The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, 
        // so "a" is considered a different type of stone from "A".
        public int NumJewelsInStones(string J, string S)
        {
            int counter = 0;
            char[] jewels = J.ToCharArray();

            // iterate through the array
            for (int i = 0; i < S.Length; i++)
            {
                // check to see if the jewell array contains a letter from the array J
                if (jewels.Contains(S[i]))
                {
                    // if the index in S contains a letter from Jewells iterate
                    counter++;
                }
            }
            
            return counter;
        }
    }

    // Output: 8
}
