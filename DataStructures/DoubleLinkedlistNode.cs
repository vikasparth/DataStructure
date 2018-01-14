using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
   public class DoubleLinkedlistNode<T>
    {
        public DoubleLinkedlistNode(T value)
        {
            Value = value;
            Next = Prev = null;
        }

        
        public T Value
        {
            get;
            set;
        }

        public DoubleLinkedlistNode<T> Next
        {
            get;
            set;
        }

        public DoubleLinkedlistNode<T> Prev
        {
            get;
            set;
        }

    }
}
