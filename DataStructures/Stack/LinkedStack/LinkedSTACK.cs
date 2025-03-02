using DataStructures.Stack.LinkedStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class LinkedSTACK
    {
        Node top;
        static int size;
        public LinkedSTACK()
        {
            top = null;
        }
        public void Push(int item)
        {
            Node newNode = new Node(item);
            newNode.NEXT = top;
            top = newNode;
            size++;
        }
        public int Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack Undeflow");
            int poppeditem = top.item;
            top = top.NEXT;
            size--;
            return poppeditem;
        }
        public bool IsEmpty() => size == 0;
        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack Undeflow");
            return top.item;
        }
        public int Count() => size;


        public void Display()
        {
            Node current = top;
            while (current != null)
            {
                Console.Write($"{current.item} ");
                current = current.NEXT;
            }
        }
    }
}
