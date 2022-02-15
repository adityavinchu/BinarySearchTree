using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return;
            }
            InsertNumber(root, new Node(data));
        }
        public void InsertNumber(Node root, Node newNode)
        {
            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertNumber(root.Left, newNode);
            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertNumber(root.Right, newNode);
            }
        }
    }
}
