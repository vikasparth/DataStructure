using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class GraphVik
    {
        int[] ArrVertices;
        int[,] AdjacentMatrix;
        
        int[] ArrayVerteicesAdjacencyList;
        System.Collections.Generic.LinkedList<int>[] AdjacencyList;

        int GraphSize = 100;
        private class CounterClass {
           public int counter;
           public int[] neighbours;

           public CounterClass()
            {
                this.counter = 0;
            }
        }

        public bool BuildSampleGraph()
        {
            try {
                ArrVertices = new int[8];
                AdjacentMatrix = new int[8,8];
                for (int vertex = 0; vertex < 8; vertex++)
                {
                    ArrVertices[vertex] = vertex + 1;
                }

                for (int i = 0; i < AdjacentMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < AdjacentMatrix.GetLength(1); j++)
                    {
                        AdjacentMatrix[i,j] = 0;
                    }
                }

                AdjacentMatrix[0,1] = 1;
                AdjacentMatrix[0,4] = 1;
                AdjacentMatrix[1,0] = 1;
                AdjacentMatrix[1,2] = 1;
                AdjacentMatrix[2,1] = 1;
                AdjacentMatrix[2,7] = 1;
                AdjacentMatrix[3,1] = 1;
                AdjacentMatrix[3,4] = 1;
                AdjacentMatrix[4,3] = 1;
                AdjacentMatrix[4,5] = 1;
                AdjacentMatrix[5,4] = 1;
                AdjacentMatrix[5,6] = 1;
                AdjacentMatrix[6,5] = 1;
                AdjacentMatrix[6,7] = 1;
                AdjacentMatrix[7,2] = 1;
                AdjacentMatrix[7,6] = 1;

                return true;
            }
            catch (IndexOutOfRangeException ior)
            {
                System.Console.WriteLine(ior.Message);
                System.Console.WriteLine(ior.StackTrace);
                return false;
            }

        }

        public bool BuildSampleGraphAdjacenyList()
        {
            try {
                ArrayVerteicesAdjacencyList = new int[10];
               AdjacencyList = new System.Collections.Generic.LinkedList<int>[10];
                for (int i = 0; i < 10; i++)
                {
                    ArrayVerteicesAdjacencyList[i] = ++i;
                }
                for (int i = 0; i < 10; i++)
                {
                    AdjacencyList[i] = new System.Collections.Generic.LinkedList<int>();
                }
                AdjacencyList[0].AddFirst(1);
                AdjacencyList[0].AddLast(2);
                AdjacencyList[0].AddLast(3);

                AdjacencyList[1].AddFirst(0);
                AdjacencyList[1].AddLast(4);

                AdjacencyList[2].AddLast(0);
                AdjacencyList[2].AddLast(5);

                AdjacencyList[3].AddLast(0);
                AdjacencyList[3].AddLast(4);
                AdjacencyList[3].AddLast(5);
                AdjacencyList[3].AddLast(7);

                AdjacencyList[4].AddLast(1);
                AdjacencyList[4].AddLast(3);
                AdjacencyList[4].AddLast(6);

                AdjacencyList[5].AddLast(2);
                AdjacencyList[5].AddLast(3);
                AdjacencyList[5].AddLast(6);

                AdjacencyList[6].AddLast(4);
                AdjacencyList[6].AddLast(5);
                AdjacencyList[6].AddLast(8);
                AdjacencyList[6].AddLast(9);
                return true;

            }
            catch(IndexOutOfRangeException ior) {
                System.Console.WriteLine(ior.Message);
                System.Console.WriteLine(ior.StackTrace);
                return false;
                   
            }
        }

        public bool AddEdgeAdjacentMatrix(GraphNode start, GraphNode end)
        {
            throw new NotImplementedException();
        }
        public bool AddEdgeAdjacentList(GraphNode start, GraphNode end)
        {
            throw new NotImplementedException();
        }
        public bool AddVertexAdjacentMatrix(GraphNode start,int data)
        {
            throw new NotImplementedException();
        }
        public bool AddVertexAdjacentList(GraphNode start, int data)
        {
            throw new NotImplementedException();
        }

        public bool AreAdjacentVertex_Matrix(int start, int end)
        {
            try
            {
                if (start > AdjacentMatrix.GetLength(1) || end > AdjacentMatrix.GetLength(1))
                {
                    System.Console.WriteLine("Provided Indexes are out of Range");
                    return false;
                }
                if (AdjacentMatrix[start,end] == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (IndexOutOfRangeException ior)
            {
                System.Console.WriteLine(ior.Message);
                System.Console.WriteLine(ior.StackTrace);
                return false;
            }
        }

        public int[] FindAdjacents_Matrix(int index)
        {
            int[] adjacentToIndex = { };
            int j = 0;
            for (int i=0;i< AdjacentMatrix.GetLength(1);i++)
            {
                if (AdjacentMatrix[index,i] == 1)
                {
                    adjacentToIndex[j] = ArrVertices[i];
                    j++;
                }
            }
            return adjacentToIndex;
        }

        public int[] FindNeighbours_Matrix(int index, int level)
        {
            CounterClass myClass = new CounterClass();
            myClass.counter = 0;
            myClass.neighbours = new int[20];
            FindNeighbours_Matrix_Recursion(index, level, myClass);
            return myClass.neighbours;
        }

        private void FindNeighbours_Matrix_Recursion(int index, int level,CounterClass myClass)
        {
            if (level == 0)
            {
                return;
            }
            level--;
            for (int i = 0; i < AdjacentMatrix.GetLength(1); i++)
            {
                if(AdjacentMatrix[index,i]==1)
                {
                    myClass.neighbours[myClass.counter] = ArrVertices[i];
                    myClass.counter++;
                    FindNeighbours_Matrix_Recursion(i, level, myClass);
                }
            }
        }

        public bool AreAdjacentVertex_List(int start, int end)


        {
            try
            {

                System.Collections.Generic.LinkedListNode<int> counter;
                counter = AdjacencyList[start].First;
                while (counter != null)
                {
                    if (counter.Value == end)
                    {
                        return true;
                    }
                    counter = counter.Next;
                }
                return false;
            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre.Message);
                System.Console.WriteLine(nre.StackTrace);
                return false;
            }
        }

        public int[] FindAdjacents_List(int start)
        {
            try {
                if (AdjacencyList[start].Count == 0)
                {
                    System.Console.WriteLine("Given Vertex does not have any adjacent nodes");
                    return null;
                }
                int[] adjacents = new int[AdjacencyList[start].Count];
                int i = 0;
                System.Collections.Generic.LinkedListNode<int> counter;
                counter = AdjacencyList[start].First;
                while (counter != null)
                {
                    adjacents[i++] = counter.Value;
                    counter = counter.Next;
                }
                return adjacents;
            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre.Message);
                System.Console.WriteLine(nre.StackTrace);
                return null;
            }
        }

        public int[] FindNeighbours_List(int index, int level)
        {
            try
            {
                CounterClass myClass = new CounterClass
                {
                    counter = 0,
                    neighbours = new int[GraphSize]
                };
                FindNeighbours_List_Recursion(index, level, myClass);
               return myClass.neighbours.Distinct<int>().ToArray<int>();
               //return myClass.neighbours;
            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre.StackTrace);
                System.Console.WriteLine(nre.Message);
                return null;
            }
            catch (IndexOutOfRangeException ior)
            {
                System.Console.WriteLine(ior.StackTrace);
                System.Console.WriteLine(ior.Message);
                return null;
            }
        }
        private void FindNeighbours_List_Recursion(int index, int level, CounterClass myClass)
        {
            try
            { 
                if (level == 0)
                {
                    return;
                }
                System.Collections.Generic.LinkedListNode<int> counter = AdjacencyList[index].First;
                while (counter != null)
                {
                    myClass.neighbours[myClass.counter] = counter.Value;
                    myClass.counter++;
                    FindNeighbours_List_Recursion(counter.Value, level-1, myClass);                  
                    counter = counter.Next;
                }
            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre.StackTrace);
                System.Console.WriteLine(nre.Message);           
            }
            catch (IndexOutOfRangeException ior)
            {
                System.Console.WriteLine(ior.StackTrace);
                System.Console.WriteLine(ior.Message);           
            }
        }
    }
}
