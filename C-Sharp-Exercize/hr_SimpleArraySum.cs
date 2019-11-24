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
            hr_SimpleArraySum test = new hr_SimpleArraySum();
            int[] nums = new int[]{ 1, 2, 3, 4, 10, 11 };

            Console.WriteLine(test.SumOfArray(nums));

        }
    }

    // Student: Steven Martinez
    //
    // Genesis: This problem is on hackerrank.com
    //
    // Summary: Given an array of integers, find the sum of its elements.
    //
    public class hr_SimpleArraySum
    {
        public int SumOfArray (int[] ar)
        {
            // declare total as integer
            int total = 0;
            
            //iterate through the array
            for (int i = 0; i < ar.Length; i++)
            {
                // add the value of i to total
                total += ar[i];
            }
            
            return total;
        }
    }

    //output: 31
}
