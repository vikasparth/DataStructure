using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
   public class BigO
    {
        int count;
        public BigO()
        {
            count = 0;
        }
        public void stringPermutation(string str)
        {
            string prefix = "";
            permutation(str, prefix);
            System.Console.WriteLine("Total number of names = {0}", count);
        }

        private void permutation(string str, string prefix)
        {
            if (str == "")
            {
                System.Console.WriteLine(prefix);
                count++;
            }
            for (int i =0; i<str.Length;i++) {
                string rem = str.Substring(0, i) + str.Substring(i + 1);
                permutation(rem, prefix + str.Substring(i, 1));
            }            
        }
        // Below method is O(N)
        public void foo(int[] array)
        {
            int sum = 0;
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            System.Console.WriteLine("Sum is {0} and product is {1}", sum, product);
        }

        //Below method is O(N square)
        public void printParis(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    System.Console.WriteLine(" At i {0} and At j {1}", i, j);
                }
            }
        }
    }
}
