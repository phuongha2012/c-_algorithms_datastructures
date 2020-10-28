using System;

namespace Algorithms_DataStructures
{
    class LinkedList
    {
        int count;
        LinkedListNode head;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        class LinkedListNode
        {
            public int data;
            public LinkedListNode next;

            public LinkedListNode(int x)
            {
                data = x;
                next = null;
            }
        }

        public void Prepend(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
            count++;
        }

        public void Append(int data)
        {
            LinkedListNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new LinkedListNode(data);
        }

        public void PrintList()
        {
            LinkedListNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
