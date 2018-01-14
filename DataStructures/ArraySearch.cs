using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
   public class ArraySearch
    {
       
        public void binarySearch(int num)
        {
            try
            {
                int[] abc;
                abc = new int[10] { 34, 54, 10, 23, 65, 12, 90, 39, 92, 11 };
                if (abc.Length == 0)
                {
                    Console.WriteLine("This is an empty array, No elements inside");
                }
                Array.Sort(abc);
                if (num < abc[0] || num > abc[abc.Length - 1])
                {
                    Console.WriteLine("The {0} number was not found in array  ", num);
                    return;
                }

                int start = 0;
                int end = abc.Length-1;
                int mid = 0;
                int counter = 0;
                while (end >= start)
                {
                    counter++;
                    
                    mid = (start + end) / 2;
                    Console.WriteLine("Loop Execution number {0} ", counter);
                    Console.WriteLine("Current Start and End Value are {0} , {1}", start, end);
                    Console.WriteLine("Current mid index value is {0}", mid);
                    
                    if (num == abc[mid])
                    {
                        Console.WriteLine("The given number {0} was found in array at index {1}", num, mid);
                        return;
                    }
                    if (num > abc[mid])
                    {
                        start = mid + 1;
                    }
                    else if (num < abc[mid])
                    {
                        end = mid - 1;
                    }
                }
                Console.WriteLine("The {0} number was not found in array  ", num);
                return;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("The code tried to reach Array out of Index  "+ex.Message.ToString());
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

    }
}
