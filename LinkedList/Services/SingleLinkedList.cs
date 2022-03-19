using LinkedList.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Services
{
    public class SingleLinkedList
    {
        public SingleNode Create(int[] arr)
        {
            SingleNode node = new SingleNode();
            SingleNode headNode = node;
            for (int i = 0; i < arr.Length-1; i++)
            {
                node.Value = arr[i];
                node.Next = new SingleNode();
                node = node.Next;
            }
            node.Value = arr[arr.Length-1];
            node.Next = null;
            return headNode;
        }

        public void Add(SingleNode node, int a)
        { 
            while(node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new SingleNode() { Value = a };
        }

        public void Insert(SingleNode head, int a, int position)
        {
            int i = 0;
            while (i < position-2 && head.Next!= null)
            {
                head = head.Next;
                i++;
            }
            SingleNode newNode = new SingleNode() { Value = a, Next = head.Next };
            head.Next = newNode;
        }

        public void Traverse(SingleNode node)
        {
            while (node.Next != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            Console.WriteLine(node.Value);
        }

        public void Update(SingleNode head, int a, int position)
        {
            int i = 1;
            while (head.Next != null)
            {
                if (i == position)
                {
                    head.Value = a;
                }
                head = head.Next;
                i++;
            }
        }

        public SingleNode Delete(SingleNode head, int position)
        {
            int i = 1;
            SingleNode newHead = head;
            if (position == 1)
            {
                newHead = head.Next;
                return newHead;
            }
            while (head.Next != null)
            {
                if (i == position-1)
                {
                    head.Next = head.Next.Next;
                    break;
                }
                head = head.Next;
                i++;
            }
            return head;
        }
    }
}
