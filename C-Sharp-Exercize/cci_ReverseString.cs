using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercize
{
    class cci_ReverseString
    {
        public void PrintReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            for (int i = 0, j = arr.Length - 1 ; i < j; i++, j--)
            {
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            string reversedString = new string(arr);
            Console.WriteLine(reversedString);
        }

        public string ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
            {
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            string reversedString = new string(arr);
            return reversedString;
        }
    }
}
