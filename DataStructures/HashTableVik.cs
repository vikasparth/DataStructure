using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class HashTableVik
    {
        public int returnIndex(string key)
        {
            int hashsize = 11;
            int one = 1;
            // int indexed =(("111-22-3333".GetHashCode() + 1 + ((("111-22-3333".GetHashCode() >> 5) + 1) % (hashsize – 1))) % (hashsize);
            int step1 = "111-22-3333".GetHashCode() + 1;
            int step2 = (("111-22-3333".GetHashCode() >> 5) + 1);
            int step3 = hashsize - one;
            int step4 = step2 % step3;
            int step5 = step4 + step1;
            int finalstep = step5 % hashsize;
            Console.WriteLine("Calculated index is {0} ", finalstep);
            return finalstep;
        }


    }
}
