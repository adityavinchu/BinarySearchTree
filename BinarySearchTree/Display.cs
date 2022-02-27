using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Display
    {
        public void DisplayTree(Node root)
        {
            if (root == null) 
                return;
            else
            { 
                DisplayTree(root.Left);
                Console.Write(root.Data + " ");
                DisplayTree(root.Right);
            }
        }
    }
}
