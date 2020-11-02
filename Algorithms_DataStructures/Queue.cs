using System;
namespace Algorithms_DataStructures
{
    class Queue
    {
        class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }

        }

        Node head; // remove things from head
        Node tail; // add things to tail

        public Queue()
        {
            head = null;
            tail = null;
        }

        public bool isEmpty()
        {
            return head == null;
        }

        public int peek()
        {
            return head.data;
        }

        public void add(int data)
        {
            Node newNode = new Node(data);

            if (tail != null)
            {
                tail.next = newNode; 
            }
            tail = newNode;

            if (head == null)
            {
                head = newNode;
            }
        }

    }
}
