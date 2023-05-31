using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedListDSA
{
    public class Tail<T>
    {

        //start of the linked list chain
        Node<T> head;
        Node<T> tail;

        public void AddLast(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;
            //step 1
            //when the first item is being added
            if (head == null)
            {
                head = newItem;
                tail = head;
            }
            else
            {
                //step 2
                //when nerw item is being added
               tail.next = newItem;
               tail = newItem;
            }

        }

        public void AddFirst(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;
            if(head == null)
            {
                head = newItem;
                tail = newItem;
            } else
            {
                newItem.next = head;
                head = newItem;
            }
        }

        public void ReadAll()
        {

            //logic to find the last node
            //loop until the last node when the head is not equal to null
            Node<T> current = head;
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
