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
            lc_TopKFrequent test = new lc_TopKFrequent();
            string[] arr1 = { "i", "love", "leetcode", "i", "love", "coding" };
            int k = 2;

            Console.WriteLine(test.TopKFrequent(arr1, k));

        }
    }

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
        public IList<string> TopKFrequent(string[] words, int k)
        {
            IDictionary<string, int> myDict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (myDict.ContainsKey(word))
                {
                    myDict[word]++;
                }

                else
                {
                    myDict.Add(word, 1);
                }

                IList<string> KFrequency = new List<string>();

                foreach (var item in myDict.OrderByDescending(R => R.Value).ThenBy(R => R.Key))
                {
                    if (k>0)
                    {
                        KFrequency.Add(item.Key);
                        k--;
                    }
                }

                return KFrequency;
            }

            return null;
        }
    }
}

