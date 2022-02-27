﻿using System;
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

            BinaryTree searchTree = new BinaryTree();
            searchTree.Add(56);
            searchTree.Add(30);
            searchTree.Add(70);
            searchTree.Add(22);
            searchTree.Add(40);
            searchTree.Add(60);
            searchTree.Add(95);
            searchTree.Add(22);
            searchTree.Add(11);
            searchTree.Add(3);
            searchTree.Add(16);
            searchTree.Add(65);
            searchTree.Add(63);
            searchTree.Add(67);

            if (searchTree.Search(63))
            {
                Console.WriteLine("It is present in our tree");
                Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("It is not present in the list");
                Console.ReadLine();
            }


        }
    }
}
