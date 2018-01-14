using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructures
{
    class DoubleLinkedlist<T> : ICollection<T>
    {
        public DoubleLinkedlistNode<T> Head
        {
            get;
            private set;
        }

        public DoubleLinkedlistNode<T> Tail
        {
            get;
            private set;
        }

        public void AddFirst(T value)
        {
            DoubleLinkedlistNode<T> node = new DoubleLinkedlistNode<T>(value);
            AddFirst(node);
        }     


        public void AddFirst(DoubleLinkedlistNode<T> node)
        {
            if (Head == null)
            {
                Head = Tail = node;
            }
            else
            {
                node.Next = Head;                
                Head.Prev = node;
                Head = node;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            DoubleLinkedlistNode<T> node = new DoubleLinkedlistNode<T>(value);
            AddLast(node);
        }

        public void AddLast(DoubleLinkedlistNode<T> node)
        {
            if (Head == null)
            {
                Head = Tail = node;                
            }
            else
            {
                DoubleLinkedlistNode<T> temp = Tail;
                Tail = node;
                node.Prev = temp;
                temp.Next = node;
                
                /*Below is my alternate implementation*/
                //node.Prev = Tail;
                //Tail.Next = node;
                //Tail = node;
            }

        }

        public void RemoveFirst()
        {
            try
            {
                if (Head == null)
                {
                    Exception ex = new Exception("Can not remove node from Empty list");
                    throw ex;
                }

                else
                {
                    if (Head == Tail)
                    {
                        Head = Tail = null;
                    }
                    else
                    {
                        Head = Head.Next;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveLast()
        {
            try
            {
                if (Head == null)
                {
                    Exception ex = new Exception("Can not remove node from Empty list");
                    throw ex;
                }

                else
                {
                    if (Head == Tail)
                    {
                        Head = Tail = null;
                    }
                    else
                    {
                        Tail = Tail.Prev;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public int Count
        {
            get;
           private set;
        }

        public bool IsReadOnly
        {
            set
            {
                value = false;
            }
            get => IsReadOnly;

        }

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

            if (Count == 0)
            {
                return false;
            }
            else
            {
                DoubleLinkedlistNode<T> current = Head;
                while (current != null)
                {
                    if (current.Value.Equals(item))
                    {
                        return true;
                    }

                }
                return false;

            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
