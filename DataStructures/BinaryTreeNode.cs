using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class BinaryTreeNode
    {
       public BinaryTreeNode left;
       public BinaryTreeNode right;
       public int data;

        public BinaryTreeNode()
        {
            this.left = null;
            this.right = null;
            this.data = -999;
        }

        public BinaryTreeNode(int value)
        {
            this.left = null;
            this.right = null;
            this.data = value;
        }
    }
}
