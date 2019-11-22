using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercize
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            lc_TwoSum test = new lc_TwoSum();
            test.twoNums(nums, target);
            Console.ReadLine();
        }
    }

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
            for (int i = 0, j = i + 1; i < nums.Length; i++)
            {
                if (target == nums[i] + nums[j]) 
                {
                    return new int[] { i, j };
                }

            }
            return null;
        }

    }   
}
