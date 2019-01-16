using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(30);
            binaryTree.Add(5);

            binaryTree.Add(35);
            binaryTree.Add(35);
            binaryTree.Add(2);
            binaryTree.Add(4);

            binaryTree.Add(36);
            binaryTree.Add(38);
            binaryTree.Add(34);
            Console.WriteLine("Brinary Tree Created!");
            Console.ReadLine();

            binaryTree.Search(binaryTree.root,34);
            Console.ReadLine();
        }
    }
}
