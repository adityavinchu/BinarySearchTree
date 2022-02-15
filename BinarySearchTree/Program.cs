using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree number = new BinaryTree();
            Node root = new Node();

            number.Insert(56);
            number.Insert(30);
            number.Insert(70);

            Display display = new Display();
            display.DisplayTree(root);

            Console.ReadLine();
        }
    }
}
