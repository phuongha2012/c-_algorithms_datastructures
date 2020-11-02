using System;

namespace Algorithms_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Prepend(4);
            linkedList.Prepend(7);
            linkedList.Prepend(2);
            linkedList.Prepend(9);
            //linkedList.Append(1);
            linkedList.InsertToPosition(3, 2);
            linkedList.PrintReverse();
        }
    }
}
