using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class LinkedList<T> : ICollection<T>
    {
        public LinkedlistNode<T> Head
        {
            get;
            private set;
        }

        public LinkedlistNode<T> Tail
        {
            get;
            private set;
        }

#region AddNode
        public void AddFirst(T value)
        {
            AddFirst(new LinkedlistNode<T>(value));
        }

        public void AddFirst(LinkedlistNode<T> node)
        {

            node.Next = Head;
            Head = node;
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new LinkedlistNode<T>(value));
        }

        public void AddLast(LinkedlistNode<T> node)
        {
            LinkedlistNode<T> temp = Tail;
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }            
            Tail = node;
            Count++;

        }
        #endregion

#region RemoveNode

        public void RemoveFirst()
        {
            if (Count <= 0)
            {
                Console.WriteLine("There is no node to be removed");
                return;
            }
            else
            {
                Head = Head.Next;
                Count--;
            }
            if (Count == 0)
            {
                Tail = null;
            }
        }

        public void RemoveLast()
        {
            if (Count <= 0)
            {
                Console.WriteLine("There is no node to be removed");
                return;
            }
            if (Count == 1)
            {
                Tail = null;               
                Count--;
            }
            else
            {
                LinkedlistNode<T> node = Head;
                while (node.Next != Tail)
                {
                    node = node.Next;
                }
                node.Next = null;
                Tail = node;
                Count--;
            }
            if (Count == 0)
            {
                Head = null;
            }

        }

#endregion


        public bool IsReadOnly
        {
            get {
                return false;
            }
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            Head = Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            LinkedlistNode<T> current = Head;
            while (current!=null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedlistNode<T> current = Head;
            for (int i = arrayIndex; current != null; i++)
            {
                array[i] = current.Value;
                current = current.Next;
            }            
        }

      

        //public bool Remove(T item)
        //{
        //    /*
        //     Possible scenarios to implement
        //     1. When Linked list is Empty - Done
        //     2. When the given item is the only value
        //     3. Removed element is to be first element
        //     4. Removed element is to be last element
        //     5. Removed element is middle element
        //     */
        //    if (Head == null)
        //    {
        //        Console.WriteLine("Can not remove the element as the linked list is Empty");
        //        return false;
        //    }
        //    LinkedlistNode<T> previous = null;
        //    LinkedlistNode<T> current = Head;

        //    while (current != null)
        //    {
        //        if (current.Value.Equals(item))
        //        {
        //            if (current == Head)
        //            {
        //                RemoveFirst();
        //                return true;
        //            }
        //            if (current == Tail)
        //            {
        //                RemoveLast();
        //                return true;
        //            }
        //            else
        //            {
        //                if (previous != null)
        //                {
        //                    previous.Next = current.Next;
        //                    Count--;
        //                    return true;
        //                }
        //                else
        //                {
        //                    try
        //                    {                               
        //                        throw new ArgumentNullException("The Value of Previous node was Null, This is an exception scenario");
        //                    }
        //                    catch (ArgumentNullException ex)
        //                    {
        //                        Console.WriteLine(ex.Message);
        //                    }

        //                }
        //            }
        //        }
        //        previous = current;
        //        current = current.Next;
        //    }
        //    return false;
        //}

        public bool Remove(T item)
        {
            /*
             Possible scenarios to implement
             1. When Linked list is Empty - Done
             2. When the given item is the only value
             3. Removed element is to be first element
             4. Removed element is to be last element
             5. Removed element is middle element
             */
            if (Head == null)
            {
                try
                {
                    throw new ArgumentNullException("The Linked list is Empty");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            else
            {
                LinkedlistNode<T> current = Head;
                LinkedlistNode<T> previous = null;

                while (current!=null)
                {
                    if (current.Value.Equals(item))
                    { 
                    if (previous != null)
                    {                            
                        if (current == Tail)
                        {
                            RemoveLast();
                        }
                        else
                        {
                            previous.Next = current.Next;
                            Count--;
                        }
                    }
                    else
                    {
                        RemoveFirst();
                    }
                        return true;
                    }
                    previous = current;
                    current = current.Next;
                }
                return false;
            }

        }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            LinkedlistNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        }
    }
}
