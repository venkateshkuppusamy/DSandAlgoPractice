using LinkedList.Services;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            var node = singleLinkedList.Create(new int[] { 1, 2, 3, 4, 5 });
            node = singleLinkedList.Delete(node, 2);
            singleLinkedList.Traverse(node);
            //singleLinkedList.Insert(node, 10, 3);
            //singleLinkedList.Traverse(node);
            //singleLinkedList.Update(node, 12, 4);
            //singleLinkedList.Traverse(node);
           // singleLinkedList.Add(node,6);
           // singleLinkedList.Traverse(node);
            Console.ReadLine();
        }
    }
}
