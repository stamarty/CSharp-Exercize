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
    //        int[] nums = { 2, 7, 11, 15 };
    //        int target = 9;

    //        lc_TwoSum test = new lc_TwoSum();
    //        test.twoNums(nums, target);
         
    //    }
    //}

    class lc_TwoSum
    {
        // Student: Steven Martinez
        //
        // Genesis: This problem is in Leetcode.com
        //
        // Summary: Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //

        public int[] twoNums (int[] nums, int target)
        {
            // iterate through array as i
            for (int i = 0; i < nums.Length; i++)
            {
                //iterate through array as j
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // check to see if [i] + [j] == target
                    if (target == (nums[i] + nums[j]))
                    {
                        // return index of numbers if [i] + [j] == target
                        return new int[] { i, j };
                    }
                }
                
            }
            // return null if ([i] + [j] != target) in any example
            return null;
        }

        //output: 0, 1

    }   
}
