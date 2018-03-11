using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class BinaryTreeVik
    {
        public BinaryTreeNode root;

        public BinaryTreeVik()
        {
            this.root = null;
        }

        public BinaryTreeVik(int data)
        {
            this.root = new BinaryTreeNode(data);
        }


        public BinaryTreeNode BuildCompleteBinaryTree(int[] numArray)
        {
            try
            {
                Queue<BinaryTreeNode> treesequence = new Queue<BinaryTreeNode>();
                BinaryTreeNode runner;
                if (this.IsEmpty())
                {
                 this.root = new BinaryTreeNode(numArray[0]);
                 treesequence.Enqueue(root);                
                }
                for(int i = 1;i<numArray.Length; i++)
                {
                    runner = treesequence.Peek();
                    if (runner.left == null)
                    {
                        BinaryTreeNode newNode = new BinaryTreeNode(numArray[i]);
                        runner.left = newNode;
                        treesequence.Enqueue(newNode);
                    }
                    else if (runner.right == null)
                    {
                        BinaryTreeNode newNode = new BinaryTreeNode(numArray[i]);
                        runner.right = newNode;
                        treesequence.Enqueue(newNode);
                        treesequence.Dequeue();
                    }

                }

                return root;
            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre.Message.ToString());
                System.Console.WriteLine(nre.StackTrace.ToString());
                return null;
            }
        }
       
        public bool IsEmpty()
        {
            if (this.root == null)
            {
                return true;
            }
            else
                return false;
        }
        public bool AddNode(int data)
        {
            BinaryTreeNode newNode = new BinaryTreeNode(data);
            BinaryTreeNode runner = this.root;
           
            throw new NotImplementedException();
        }
        public bool PrintPreOrder(BinaryTreeNode root)
        {
            try
            {
                if (this.IsEmpty())
                {
                    System.Console.WriteLine("This is an empty tree, nothing to print");
                    return false;
                }
                PreOrderTraverse(root);
                return true;

            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre.Message.ToString());
                System.Console.WriteLine(nre.StackTrace.ToString());
                return false;
            }
        }

        private void PreOrderTraverse(BinaryTreeNode node)
        {
            try {
                if (node == null)
                {
                    return;
                }
                PreOrderTraverse(node.left);
                System.Console.WriteLine(node.data);
                PreOrderTraverse(node.right);
            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre.Message.ToString());
                System.Console.WriteLine(nre.StackTrace.ToString());                
            }

        }

        public bool PrintPostOrder(BinaryTreeNode btv)
        {
            try
            {
                if (this.IsEmpty())
                {
                    System.Console.WriteLine("This is an empty tree, nothing to print");
                    return false;
                }
                PostOrderTraverse(root);
                return true;

            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre.Message.ToString());
                System.Console.WriteLine(nre.StackTrace.ToString());
                return false;
            }
        }

        private void PostOrderTraverse(BinaryTreeNode node)
        {
            try {
                if (node == null)
                {
                    return;
                }
                PostOrderTraverse(node.right);
                System.Console.WriteLine(node.data);
                PostOrderTraverse(node.left);
            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre.Message);
                System.Console.WriteLine(nre.StackTrace);                
            }
        }
        public bool PrintInOrder(BinaryTreeNode btv)
        {
            try
            {
                if (this.IsEmpty())
                {
                    System.Console.WriteLine("This is an empty tree, nothing to print");
                    return false;
                }
                InOrderTraverse(root);
                return true;

            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre.Message.ToString());
                System.Console.WriteLine(nre.StackTrace.ToString());
                return false;
            }
        }

        private void InOrderTraverse(BinaryTreeNode node)
        {

            try {
                if(node==null)
                {
                    return;
                }
                System.Console.WriteLine(node.data);
                InOrderTraverse(node.left);
                InOrderTraverse(node.right);
            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre.Message);
                System.Console.WriteLine(nre.StackTrace);
            }

        }

        public bool IsCompleteBinaryTree()
        {
            throw new NotImplementedException();
        }
        public bool IsPerfectBinaryTree()
        {
            throw new NotImplementedException();
        }
        public bool IsBalancedBinaryTree()
        {
            throw new NotImplementedException();
        }
        public int Height()
        {
            throw new NotImplementedException();
        }
    }
}
