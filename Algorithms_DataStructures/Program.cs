using System;

namespace Algorithms_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.PrependNode(4);
            linkedList.PrependNode(7);
            linkedList.PrependNode(2);
            linkedList.PrependNode(9);
            linkedList.PrintList();
        }
    }
}
