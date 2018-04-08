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

            //string compressedstring =  chap1.StringCompression("aabccccaa");
            // System.Console.WriteLine(compressedstring);

            // Testing IsSubString method below
            /* string src = "abcaba";
             string target = "aaaaaaaacbaabcaba";
             bool result = chap1.isSubString(src.ToCharArray(), target.ToCharArray());
             System.Console.WriteLine(result.ToString());
             */
            /*Below method is a solution to the problem where we need to roate a matrix by 90 degrees*/
            //Testing Rotate matrix method below
            //float[,] before = new float[3, 3];
            //int number = 1;
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int column = 0; column < 3; column++)
            //    {
            //        before[row, column] = number++;                   
            //    }
            //}
            //System.Console.WriteLine("Matrix before rotation is as below");
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int column = 0; column < 3; column++)
            //    {
            //       System.Console.Write("{0},", before[row, column]);
            //    }
            //    System.Console.WriteLine("");            }
            
            //chap1.RotateMatrix(before);
            //chap1.RotateMatrixApproach2(before);

            /*Below method is a solution to the problem where we need to mark a row i and column j as 0 
              if element arr[i,j] is 0*/
            //int[,] arr = new int[3,4] { { 1, 2, 3 ,4}, { 5, 0, 6,7 }, { 8,9,10,11 } };
            //chap1.ZeroMatrix(arr);
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + ",");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion Chapter1


        #region Chapter4&Trees
            /*Below code tests the method to build a binary tree*/
            //BinaryTreeVik btvComplete = new BinaryTreeVik();
            //BinaryTreeNode root = null;
            //int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //root = btvComplete.BuildCompleteBinaryTree(numArray);
            //btvComplete.PrintPreOrder(root);
            //System.Console.WriteLine("--------------------------------------------");
            //btvComplete.PrintPostOrder(root);
            //System.Console.WriteLine("--------------------------------------------");
            //btvComplete.PrintInOrder(root);

            //BinaryTreeVik btvSearch = new BinaryTreeVik();           
            //int[] numArray = { 10, 6, 12, 5, 8, 11, 16};
            //btvSearch.BuildBinarySearchTree(numArray);


            //btvSearch.PrintPreOrder(btvSearch.root);
            //System.Console.WriteLine("--------------------------------------------");
            //btvSearch.PrintInOrder(btvSearch.root);
            //System.Console.WriteLine("--------------------------------------------");
            //btvSearch.PrintPostOrder(btvSearch.root);

            //btvSearch.InsertToBST(7);
            //btvSearch.InsertToBST(9);
            //btvSearch.DeleteFromBST(10);
            //System.Console.WriteLine("--------------------------------------------");
            //btvSearch.PrintPreOrder(btvSearch.root);
            //System.Console.WriteLine("--------------------------------------------");
            //btvSearch.PrintInOrder(btvSearch.root);
            //System.Console.WriteLine("--------------------------------------------");
            //btvSearch.PrintPostOrder(btvSearch.root);
            ////btvSearch.SearchInBST(11);

            //System.Console.WriteLine("--------------------------------------------");
            //btvSearch.PrintElementsAtLevel(btvSearch.root, 0, 2);

            GraphVik graph1 = new GraphVik();
            //graph1.BuildSampleGraph();
            //graph1.FindNeighbours_Matrix(5, 3);

            int[] result = new int[100];
            graph1.BuildSampleGraphAdjacenyList();
            result = graph1.FindAdjacents_List(0);
            System.Console.WriteLine(graph1.AreAdjacentVertex_List(0, 4));
            for (int i = 0; i < result.Length; i++)
            {
                System.Console.WriteLine(result[i] + ",");
            }
            result = new int[20];
            result = graph1.FindNeighbours_List(0, 2);
            for (int i = 0; i < result.Length; i++)
            {
                System.Console.WriteLine(result[i] + ",");
            }
            #endregion Chapter4&Trees


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
