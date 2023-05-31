using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedListDSA
{
    //this represents a node in the linked list ADT
    public class Node
    {
        public object data = null;
        public Node next = null;

    }

    public class Node<T>
    {
        public T data;
        public Node<T> next;
    }
}
