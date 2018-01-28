using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class HashTableVik
    {
        private string[] hashTableArray;
        private int hashSize;
        public HashTableVik()
        {
            hashSize = 100;
            hashTableArray =  new string[hashSize];
        }
        public HashTableVik(int hashSizeParam)
        {
            hashSize = hashSizeParam;
            hashTableArray = new string[hashSize];
        }

    public int ReturnIndex(string key)
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

        public int CalculateIndex(string key)
        {
            int index = Math.Abs(key.GetHashCode()) % hashTableArray.Length;
            return index;
        }

        public void Add(string key,string value)
        {
            try {
                int index = CalculateIndex(key);
                if (hashTableArray[index] != null)
                {
                    // Do  probing until you find available space                   
                    while (hashTableArray[index] != null & index < hashTableArray.Length)
                    {
                        index = ProbeNext(index);
                    }
                }
                if (index < hashTableArray.Length)
                {
                    hashTableArray[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException ex) {
                System.Console.WriteLine("Index reached Out of bound for the hash table,");
                System.Console.WriteLine("Element could not be added");
                System.Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        public void CopyTo(string[] target)
        {
            target = new string[hashTableArray.Length];
            for (int i = 0; i < hashTableArray.Length;i++)
            {
                target[i] = hashTableArray[i];
            }
        }

        public bool ContainsKey(string key)
        {
         throw new System.NotImplementedException();
        }


        public int ProbeNext(int currentIndex)
        {
            try { 
            int newIndex = currentIndex;
           
                    // Below can be replaced by any probe formula
                newIndex++;     
            if(newIndex<hashTableArray.Length)
            {
                return newIndex;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            }
            catch (IndexOutOfRangeException ex) {
                System.Console.WriteLine("Index reached Out of bound for the hash table,");
                System.Console.WriteLine("Element could not be added");
                System.Console.WriteLine(ex.StackTrace.ToString());
                return -1;
            }
        }
        public bool Contains(string key,string value)
        {
            int index = CalculateIndex(key);
            if(hashTableArray[index]==value)
            {
                return true;
            }
            else
            {
                while(index<hashTableArray.Length)
                {
                    index = ProbeNext(index);
                    if(hashTableArray[index]==value || index==-1)
                    {
                        break;
                    }
                }
                if(index==-1||index>=hashTableArray.Length)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool Remove(string key, string value)
        {
            int index = CalculateIndex(key);
            if(hashTableArray[index]==value)
            {
                hashTableArray[index] = null;
                return true;
            }
            else
            {
                while (index < hashTableArray.Length)
                {
                    index = ProbeNext(index);
                    if (hashTableArray[index] == value || index == -1)
                    {
                        break;
                    }
                }
                if (index == -1 || index >= hashTableArray.Length)
                {
                    return false;
                }
                else
                {
                    hashTableArray[index] = null;
                    return true;
                }
            }
        }

        public string FindValue(string key)
        {
            int index = CalculateIndex(key);
            string value = hashTableArray[index];
            return value;
        }

    }
}
