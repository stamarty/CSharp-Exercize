using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Exercize
{
    class Program
    {
        static void Main(string[] args)
        {
            lc_PalindromeCheck test = new lc_PalindromeCheck();
            string palcheck1 = "racecar";
            string palcheck2 = "steven";
            string palcheck3 = "A man, a plan, a canal: Panama";
            string palcheck4 = "race a car";

            Console.WriteLine(test.IsPalindrome(palcheck1));
            Console.WriteLine(test.IsPalindrome(palcheck2));
            Console.WriteLine(test.IsPalindrome(palcheck3));
            Console.WriteLine(test.IsPalindrome(palcheck4));

        }
    }

    // Student: Steven Martinez
    //
    // Genesis: This problem is in Leetcode.com
    // Link: https://leetcode.com/problems/valid-palindrome/
    //
    // Summary: Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
    // Note: For the purpose of this problem, we define empty string as valid palindrome.
    //

    public class lc_PalindromeCheck
    {
        // bool is returned true = palindrome; false = not palindrome
        public bool IsPalindrome (string S)
        {
            // check to see if the provided string is empty or null
            // in this case empty is treated as a legitimate palindrome
            if (string.IsNullOrEmpty(S))
            {
                return true;
            }

            // we need to iterate through the string from both directions
            // a for loop isn't very appropriate here, because there is a 
            // possibility that we run into punctuation.
            // declare pointers to iterate from either end of the string
            int i = 0, j = S.Length - 1;

            // loop will continue until  we reach the middle. 
            while (i < j)
            {
                // checks if the front pointer is pointing at something
                // other than a letter or digit. Moves the pointer forward
                // if no letter or digit is found.
                if (!char.IsLetterOrDigit(s[i]))
                {
                    // increments front pointer
                    i++;
                }

                // checks if the back pointer is pointing at something
                // other than a letter or digit. Moves the pointer backwards
                // if no letter or digit is found.
                else if (!char.IsLetterOrDigit(S[j]))
                {
                    // decrements back pointer
                    j--;
                }

                // if both front pointer (i) and back pointer (j) are letters or digits
                // checks to see if they are different. If they are different then the 
                // string cannot be a palindrome.
                else if (char.ToLower(S[i++]) != char.ToLower(S[j--]))
                {
                    return false;
                }
            }

            // if all other checks check out, then  return true. 
            return true;

        }
    }
}
