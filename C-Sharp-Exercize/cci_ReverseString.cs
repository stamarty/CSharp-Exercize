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
    //        cci_ReverseString test = new cci_ReverseString();

    //        // prints to the console as part of the constructor
    //        test.PrintReverseString("Here's a string to turn around");

    //        // prints to the console from the return in the second constructor
    //        Console.WriteLine(test.ReverseString("here's a second string"));


    //    }
    //}

    //class cci_ReverseString
    //{
    //    // reverses string entered as parameter and prints to console. 
    //    // I am experimenting with building different constructors and passing
    //    // values into each to see how building them works.
    //    public void PrintReverseString(string str)
    //    {
    //        // turn string into char array, cycle through the array and replace first char with last etc....
    //        char[] arr = str.ToCharArray();
    //        for (int i = 0, j = arr.Length - 1 ; i < j; i++, j--)
    //        {
    //            char temp = arr[i];
    //            arr[i] = arr[j];
    //            arr[j] = temp;
    //        }

    //        string reversedString = new string(arr);
    //        Console.WriteLine(reversedString);
    //    }

    //    // returns the string entered as a parameter reversed.
    //    // turn string into char array, cycle through the array and replace first char with last etc....
    //    public string ReverseString(string str)
    //    {
    //        char[] arr = str.ToCharArray();
    //        for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
    //        {
    //            char temp = arr[i];
    //            arr[i] = arr[j];
    //            arr[j] = temp;
    //        }

    //        string reversedString = new string(arr);
    //        return reversedString;
    //    }
    //}

    //// Output - dnuora nrut ot gnirts a s'ereH
    //// Output - gnirts dnoces a s'ereh
}
