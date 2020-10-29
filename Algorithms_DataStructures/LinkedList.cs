using System;
using System.Collections;

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
            if (head == null)
            {
                head = new LinkedListNode(data);
                return;
            }
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new LinkedListNode(data);
        }

        public void DeleteWithValue(int data)
        {
            if (head == null) return;
            if (head.data == data)
            {
                head = head.next;
                return;
            }

            LinkedListNode current = head;
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }

        public void Print()
        {
            LinkedListNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void PrintReverse()
        {
            Stack reversedList = new Stack();
            LinkedListNode current = head;
            while (current != null)
            {
                reversedList.Push(current.data);
                current = current.next;
            }

            foreach(int number in reversedList)
            {
                Console.WriteLine(number);
            }
        }

        public void InsertToPosition(int data, int position)
        {
            LinkedListNode newNode = new LinkedListNode(data);

            if (position == 0)
            {
                newNode.next = head;
                head = newNode;
            } else
            {
                LinkedListNode current = head;
                for (var i = 0; i < position - 1; i++)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
        }


    }
}
