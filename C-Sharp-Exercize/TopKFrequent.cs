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
    //        lc_TopKFrequent test = new lc_TopKFrequent();
    //        string[] arr1 = { "i", "love", "leetcode", "i", "love", "coding" };
    //        int k = 2;

    //        Console.WriteLine(string.Join(System.Environment.NewLine, test.TopKFrequent(arr1, k)));
    //    }
    //}

    // Student: Steven Martinez
    //
    // Genesis: This problem is in Leetcode.com
    // Link: https://leetcode.com/problems/top-k-frequent-words
    //
    // Summary: Given a non-empty list of words, return the k most frequent elements.
    // Your answer should be sorted by frequency from highest to lowest.If two words have the same frequency, 
    // then the word with the lower alphabetical order comes first.
    //

    public class lc_TopKFrequent
    {
        // method returns a list of K length with the top k most frequent words
        public IList<string> TopKFrequent(string[] words, int k)
        {
            // create dictionary from the string array words
            IDictionary<string, int> myDict = new Dictionary<string, int>();

            // cycle through the array
            foreach (var word in words)
            {
                // if dictionary already contains the word
                if (myDict.ContainsKey(word))
                {
                    // increment the value by 1
                    myDict[word]++;
                }

                // if the dictionary does not contain the word
                else
                {
                    // add the word intialize the value to 1
                    myDict.Add(word, 1);
                }

            }

            // create a list to hold the key from dictionary
            IList<string> KFrequency = new List<string>();

            // cycle through the dictionary. order the list by value, then alphabetically by key
            foreach (var item in myDict.OrderByDescending(R => R.Value).ThenBy(R => R.Key))
            {
                // do it as many times as k is
                if (k > 0)
                {
                    // add key to the list
                    KFrequency.Add(item.Key);
                    //decrement k
                    k--;
                }
            }

            // return the list. The list should only contain k elements
            return KFrequency;
        }
    }
}

