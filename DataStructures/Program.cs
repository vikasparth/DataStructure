using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node {
        public int value { get; set; }
        public Node next { get; set; }
    }    

    class Program
    {
        private static Hashtable employees = new Hashtable();
        static void Main(string[] args)
        {
            //Node first = new Node() { value = 5 };

            //Node middle = new Node() { value = 7 };
            //first.next = middle;

            //Node last = new Node() { value = 11 };
            //middle.next = last;

            //PrintList(first);
            StackVik aj;
            
            #region HashTable
            // Add some values to the Hashtable, indexed by a string key
            employees.Add("111-22-3333", "Scott");
            employees.Add("222-33-4444", "Sam");
            employees.Add("333-44-55555", "Jisun");

            // Access a particular key
            if (employees.ContainsKey("111-22-3333"))
            {
                string empName = (string)employees["111-22-3333"];
                Console.WriteLine("Employee 111-22-3333's name is: " + empName);
            }
            else
                Console.WriteLine("Employee 111-22-3333 is not in the hash table...");
            foreach (string key in employees.Keys)
                Console.WriteLine("Value at employees[\"" + key + "\"] = " + employees[key].ToString());

            int hashCode = "111-22-3333".GetHashCode();
            Console.WriteLine("Hash Code valur for 111 - 22 - 3333 is ={0}", hashCode);
            Console.WriteLine(employees.Count);
            HashTableVik myHash = new HashTableVik();
            myHash.returnIndex("111-22-3333");
            myHash.returnIndex("222-33-4444");
            myHash.returnIndex("333-44-55555");

           // int indexed =(("111-22-3333".GetHashCode() + 1 + ((("111-22-3333".GetHashCode() >> 5) + 1) % (hashsize – 1))) % (hashsize);
             
            #endregion HashTable

            #region ArraySearch
            //ArraySearch searchNum = new ArraySearch();
            //searchNum.binarySearch(91);

            //List<int> powerOf2 = new List<int>();
            //powerOf2.Add(2);
            //powerOf2.Add(4);
            //powerOf2.Add(8);
            //powerOf2.Add(16);
            //powerOf2.Add(32);
            //powerOf2.Add(64);

            //int found = powerOf2.Find(a=>a.Equals(4));
            //int notfound = powerOf2.Find(b=>b.Equals(6));
            //int indexoffour = powerOf2.IndexOf(8);

            //Console.WriteLine(found);
            //Console.WriteLine(notfound);
            //Console.WriteLine(indexoffour);
            //Console.Read();
            #endregion arraySearch
            #region QueueOperations
            //QueueVik q = new QueueVik(2);
            //q.PushElement(3);
            //q.PushElement(5);
            //q.PushElement(7);
            //q.PushElement(9);
            ////q.PushElement(11);
            ////q.PushElement(13);
            ////q.PushElement(15);
            ////q.PushElement(17);
            ////Console.WriteLine(q.GetElement());
            ////Console.WriteLine(q.GetElement());
            ////Console.WriteLine(q.GetElement());
            ////Console.WriteLine(q.GetElement());
            ////Console.WriteLine(q.GetElement());
            ////Console.WriteLine(q.GetElement());
            //Console.WriteLine(q.IndexOf(5));
            //Console.ReadLine();
            #endregion QueueOperations
            //LinkedList<int> myIntegers = new LinkedList<int>();
            //LinkedlistNode<int> node = new LinkedlistNode<int>(11);
            //myIntegers.Add(3);
            //myIntegers.Add(5);
            //myIntegers.AddFirst(1);
            //myIntegers.AddLast(7);

            //LinkedlistNode<int> current = myIntegers.Head;
            //while (current != null)
            //{
            //    Console.WriteLine(current.Value);
            //    current = current.Next;
            //}
            //Console.Read();
            //myIntegers.Remove(5);
            //current = myIntegers.Head;
            //while (current != null)
            //{
            //    Console.WriteLine(current.Value);
            //    current = current.Next;
            //}
            //Console.Read();
            //myIntegers.RemoveLast();
            //current = myIntegers.Head;
            //while (current != null)
            //{
            //    Console.WriteLine(current.Value);
            //    current = current.Next;
            //}
            //Console.Read();

            //myIntegers.AddLast(node);
            //current = myIntegers.Head;
            //while (current != null)
            //{
            //    Console.WriteLine(current.Value);
            //    current = current.Next;
            //}
            //Console.Read();

            //myIntegers.RemoveFirst();
            //current = myIntegers.Head;
            //while (current != null)
            //{
            //    Console.WriteLine(current.Value);
            //    current = current.Next;
            //}
            //Console.Read();

            //myIntegers.Remove(11);
            //current = myIntegers.Head;

            //foreach (int temp1 in  myIntegers)
            //{
            //    Console.WriteLine(temp1);

            //}
            //Console.Read();
        }

                static public void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
            Console.Read();
        }
    }
}
