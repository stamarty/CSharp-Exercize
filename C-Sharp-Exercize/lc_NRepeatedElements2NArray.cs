using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Exercize
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        lc_NRepeatedElements2NArray test = new lc_NRepeatedElements2NArray();
    //        int[] array1 = { 1, 2, 3, 3 };
    //        int[] array2 = { 2, 1, 2, 5, 3, 2 };
    //        int[] array3 = { 5, 1, 5, 2, 5, 3, 5, 4 };

    //        Console.WriteLine(test.RepeatedNTimes(array1));
    //        Console.WriteLine(test.RepeatedNTimes(array2));
    //        Console.WriteLine(test.RepeatedNTimes(array3));

    //    }
    //}


    // Student: Steven Martinez
    //
    // Genesis: This problem is in Leetcode.com
    // Link: https://leetcode.com/problems/n-repeated-element-in-size-2n-array/
    //
    // Summary: In an array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.
    // Return the element repeated N times.
    // The below method essentially looks for duplicates and returns the duplicate value.

    public class lc_NRepeatedElements2NArray
    {
        public int RepeatedNTimes(int[] A)
        {
            // check that the array can validly hold the data we are looking for
            if (A == null || A.Length < 4)
            {
                // throw exception if not.
                throw new ArgumentException("Invalid Input");
            }

            // create new HashSet. HashSets can only contain unique values
            HashSet<int> HS = new HashSet<int>();

            // move through the array and decide where to put each value
            foreach (var i in A)
            {
                // if the HashSet already contains the number then it is a duplicate
                // which means you found the value that is duplicated within the array
                if (HS.Contains(A[i]))
                {
                    // so return the value of the index on the array
                    return i;
                }

                // if the value isn't in the HashSet, it needs to be added
                else
                {
                    // so we'll add it here.
                    HS.Add(A[i]);
                }
            }
            // return 0 if no duplicates
            return 0;
        }
    }
    //output test case 1: 3
    //output test case 2: 2
    //output test case 3: 5
}
