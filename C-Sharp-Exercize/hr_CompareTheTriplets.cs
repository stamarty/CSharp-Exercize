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
    //        hr_CompareTheTriplets test = new hr_CompareTheTriplets();

    //        List<int> list1 = new List<int> { 50, 77, 90 };
    //        List<int> list2 = new List<int> { 57, 77, 89 };
    //        test.CompareTriplets(list1, list2);

    //    }
    //}

    public class hr_CompareTheTriplets
    {
        public List<int> CompareTriplets(List<int> a, List<int> b)
        {

            // declare 
            int aTotal = 0, bTotal = 0;
            
            for (int i = 0; i < 3; i++)
            {
                // if a == b keep on keeping on
                if (a[i] == b[i])
                {
                    continue;
                }

                // if a is bigger than b give a a point
                else if (a[i] > b[i])
                {
                    aTotal++;
                }

                // give b a point
                else
                {
                    bTotal++;
                }
            }
            return new List<int> { aTotal, bTotal };
        }
    }
}
