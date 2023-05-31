using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedListDSA
{
    public class LinkedListDSA
    {
        //start of the linked list chain
        Node head = null;

        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;

            if (head == null)
            {
                head = newItem;
                head.next = null;
            }
            else
            {
                Node current = head;
                //loop and find the last node
                //white the current element is not null set current as the next as the next node
                while (current.next != null)
                {
                    current = current.next;
                }
                //if it is null this is the last element
                current.next = newItem;
                newItem.next = null;

            }

        }

        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            //this is not the first item, the current head becomes the next item
            newItem.next = head;
            //thsi newitem becomes the head
            head = newItem;
        }

        public void ReadAll()
        {

            //logic to find the last node
            //loop until the last node when the head is not equal to null
            Node current = head;
            while (current.next != null)
            {
                //display the data inside
                Console.WriteLine(current.data);
                current = current.next;
            }
                Console.WriteLine(current.data);


        }
    }
}
