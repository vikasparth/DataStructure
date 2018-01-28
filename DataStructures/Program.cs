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


            #region HashTable
            //HashTableVik ht = new HashTableVik(50);
            //int code = "Vikas".GetHashCode();
            //ht.Add("Vikas", "Parth");
            //ht.Add("Shaifali", "Chanda");
            //ht.Add("Shourya", "Kanha");
            //ht.Add("Shreya", "Chahal");
            //ht.Add("Vikas", "Sharma");
            //string value = ht.FindValue("Vikas");
            //System.Console.WriteLine("Home name for  Vikas is {0}", value);
            // value = ht.FindValue("Shaifali");
            //System.Console.WriteLine("Home name for Shaifali is {0}", value);
            // value = ht.FindValue("Shourya");
            //System.Console.WriteLine("Home name for Shourya is {0}", value);
            // value = ht.FindValue("Shreya");
            //System.Console.WriteLine("Home name for Shreya is {0}", value);
            //ht.Remove("Vikas","Sharma");
            //value = ht.FindValue("Vikas");
            //System.Console.WriteLine("Home name for  Vikas is {0}", value);

            //Dictionary<string,string> ht2 = new Dictionary<string, string>();
            //ht2.Add("Vikas", "Sharma");
            //ht2.Add("Vikas", "Parth");
            //value = ht2["Vikas"].ToString();
            //System.Console.WriteLine("Home name for  Vikas is {0}", value);
            // Add some values to the Hashtable, indexed by a string key
            //employees.Add("111-22-3333", "Scott");
            //employees.Add("222-33-4444", "Sam");
            //employees.Add("333-44-55555", "Jisun");

            //// Access a particular key
            //if (employees.ContainsKey("111-22-3333"))
            //{
            //    string empName = (string)employees["111-22-3333"];
            //    Console.WriteLine("Employee 111-22-3333's name is: " + empName);
            //}
            //else
            //    Console.WriteLine("Employee 111-22-3333 is not in the hash table...");
            //foreach (string key in employees.Keys)
            //    Console.WriteLine("Value at employees[\"" + key + "\"] = " + employees[key].ToString());

            //int hashCode = "111-22-3333".GetHashCode();
            //Console.WriteLine("Hash Code valur for 111 - 22 - 3333 is ={0}", hashCode);
            //Console.WriteLine(employees.Count);
            //HashTableVik myHash = new HashTableVik();
            //myHash.ReturnIndex("111-22-3333");
            //myHash.ReturnIndex("222-33-4444");
            //myHash.ReturnIndex("333-44-55555");

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

            #region BigO
            //BigO bigoh = new BigO();
            //bigoh.stringPermutation("VIKAS");
            //System.Console.Read();
            #endregion BigO


            #region Chapter1
            Chapter1 chap1 = new Chapter1();
            //string urltobe = "Vikas Kumar Sharma";
            //int length = 18;
            //char[] temp = new char[100];
            //char[] temp2 = new char[100];
            //temp = urltobe.ToCharArray();            
            //temp2 = chap1.URLify(temp, length);
            //string urlfinal = new string(temp2);
            //System.Console.WriteLine(urlfinal);

            //chap1.PalindromePermutation("Tacocat");

            //chap1.OneAway("Pale".ToCharArray(), "ale".ToCharArray());

           string compressedstring =  chap1.StringCompression("aabccccaa");
            System.Console.WriteLine(compressedstring);

            #endregion Chapter1
            




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
            Console.Read();
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
