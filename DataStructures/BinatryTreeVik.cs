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
        public BinaryTreeNode BuildBinarySearchTree(int[] numArray)
        {
            try
            {
                if (numArray.Length == 0)
                {
                    Console.WriteLine("The provided Array is Empty, Please provide a valid array");
                    return null;
                }
                root = new BinaryTreeNode(numArray[0]);               
                if (numArray.Length > 1)
                {
                    for (int i = 1; i < numArray.Length; i++)
                    {
                        InsertToBST(numArray[i]);
                    }
                }
                return root;
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
                Console.WriteLine(nre.StackTrace);
                return null;
            }
        }

        public bool InsertToBST(int num)
        {
            try
            {
                if (this.IsEmpty())
                {
                    root = new BinaryTreeNode(num);
                }
                else
                {
                    BinaryTreeNode current = root;
                    BinaryTreeNode previous = root;
                    while (current != null)
                    {
                        previous = current;
                        if (num <= current.data)
                        {
                            current = current.left;
                        }
                        else
                        {
                            current = current.right;
                        }
                    }
                    BinaryTreeNode newNode = new BinaryTreeNode(num);
                    if (num <= previous.data)
                    {
                        previous.left = newNode;
                    }
                    else
                    {
                        previous.right = newNode;
                    }
                }
                return true;
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
                Console.WriteLine(nre.StackTrace);
                return false;
            }
        }

        public bool DeleteFromBST(int num)
        {
            try {
                if (this.IsEmpty())
                {
                    Console.WriteLine("Tree is empty, nothing to be removed");
                    return false;
                }
                BinaryTreeNode current = this.root;
                BinaryTreeNode previous = this.root;
                while (current != null)
                {                 
                    if (num == current.data)
                    {
                        Console.WriteLine("Giiven number {0} was found", num);
                        break;
                    }
                  previous = current;
                   if (num < current.data)
                    {
                        current = current.left;
                    }
                   else
                    {
                        current = current.right;
                    }
                    
                }
                // Below  if condition handles the special case when node to be delted is root node
                if (current == this.root)
                {
                    if (current.left == null || current.right == null)
                    {
                        if (current.left == null)
                        {
                            this.root = current.right;
                        }
                        else
                        {
                            this.root = current.left;
                        }
                    }
                    else
                    {
                        BinaryTreeNode newRoot = this.root.left;
                        BinaryTreeNode newRootPrev = this.root.left;
                        while (newRoot.right != null)
                        {
                            newRootPrev = newRoot;
                            newRoot = newRoot.right;
                        }
                        newRootPrev.right = null;
                        newRoot.left = this.root.left;
                        newRoot.right = this.root.right;
                        this.root = newRoot;
                    }                   
                }
                // Below code will be executed to handle the case when node to be deleted is not root node
                else
                {
                    if (current.left == null || current.right == null)
                    {
                        if (current.left == null)
                        {
                            previous.right = current.right;
                        }
                       else
                        {
                            previous.left = current.left;
                        }
                    }
                    else
                    {
                        BinaryTreeNode newCurrent = current.left;

                        BinaryTreeNode newPrevious = current.left;
                        while (newCurrent.right != null)
                        {
                            newPrevious = newCurrent;
                            newCurrent = newCurrent.right;
                        }
                        newCurrent.right = current.right;
                        current.left = null;
                        current.right = null;
                        if (previous.left == current)
                        {
                            previous.left = newCurrent;
                        }
                        else
                        {
                            previous.right = newCurrent;
                        }
                    }
                }
                return true;
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
                Console.WriteLine(nre.StackTrace);
                return false;
            }
        }

        public BinaryTreeNode SearchInBST(int num)
        {
            try {
                if(this.IsEmpty())
                {
                    Console.WriteLine("Tree is Empty, nothing to be searched from");
                    return null;
                }
                BinaryTreeNode current = this.root;                
                while (current != null)
                {                   
                    if (num == current.data)
                    {
                        Console.WriteLine("Giiven number {0} was found",num);
                        return current;
                    }
                    else
                    {
                        if (num < current.data)
                        {
                            current = current.left;
                        }
                        else
                        {
                            current = current.right;
                        }
                    }
                }
                Console.WriteLine("Giiven number {0} does not exist in tree", num);
                return current;
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
                Console.WriteLine(nre.StackTrace);
                return null;
            }
        }


        public void PrintElementsAtLevel(BinaryTreeNode node, int currentlevel, int expectedlevel)
        {
            if (currentlevel == expectedlevel && node!=null)
            {
                System.Console.WriteLine(node.data);
                return;
            }
            currentlevel++;
            if (node.left != null)
            {
                PrintElementsAtLevel(node.left, currentlevel, expectedlevel);
            }
            //PrintElementsAtLevel(node, currentlevel, expectedlevel);
            if (node.right != null)
            {
                PrintElementsAtLevel(node.right, currentlevel, expectedlevel);
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
