using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_BinarySearchTree
{
    class BinaryTree
    {

      public  Node root;
        int position;
        public BinaryTree()
        {
            root = null;
        }
        public void Add(int value)
        {
            Node temp = new Node(value);
            if (root == null)
            {
                root = temp;
            }
            else if (root != null)
            {
                Node node = root;
                Node tempnode;
                while (true)
                {
                    tempnode = node;
                    if (value <= node.data)
                    {
                        node = node.leftNode;
                        if (node == null)
                        {
                            tempnode.leftNode = temp;
                            break;
                        }
                    }
                    else
                    {
                        node = node.rightNode;
                        if (node == null)
                        {
                            tempnode.rightNode = temp;
                            break;
                        }
                    }
                }
            }
        }

      public  void Search(Node node, int key)
        {
            position += 1;
            if (node == null)
            {
                Console.WriteLine("No item Found: {0}", position);
            }
            else if (node.data == key)
            {
                Console.WriteLine("item Found: {0}", position);
            }
            else  if (key < node.data)
            {
                Search(node.leftNode, key);
            }
            else
            {
               Search(node.rightNode, key);
            }
        }
    }
}
