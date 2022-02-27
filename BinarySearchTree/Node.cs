using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left ; 
        public Node Right;
        public Node()
        {

        }
        public Node(int data)
        {
            this.Data = data;

        }
    }
}
