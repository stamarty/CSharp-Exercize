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
            string someString = "This is a string with words, words with Strings have words in them.";

        }
    }

    public class MostCommonWordInString
    {
        //What is most common word in string
        //separated by space
        public void mostCommon(string a)
        {
            int index1 = 0, index2;

            for (int i = 0; i < a.Length; i++)
            {
                if (a.[i] = " ")
                {
                    index2 = (i - 1);

                    string newWord = a.Substring(index1, index2);

                }
            }
        }
    }
}