using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace msc_BinarySearchTree
{
    class Node
    {
       public int data;
       public Node leftNode;
       public Node rightNode;

        public Node(int value)
        {
            data = value;
            leftNode = null;
            rightNode = null;
        }

    }
}
