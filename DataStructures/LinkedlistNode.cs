using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedlistNode<T>
    {
        public LinkedlistNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public LinkedlistNode<T> Next { get; set; }

    }
}
