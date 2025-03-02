using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class STACK
    {
        int[] data;
        int top;
        int _size;
        public STACK(int size)
        {
            data = new int[size];
            _size = size;
            top = -1;
        }

        public bool IsEmpty() => count() == 0;
        public bool IsFull() => count() == _size;
        public int count() => top + 1;
        public void Push(int item)
        {
            if (IsFull())
                throw new StackOverflowException();
            else
                data[++top] = item;
        }
        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack Underflow");
            return data[top--];
        }
        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack Underflow");
            return data[top];
        }
        public void Display()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();
        }
    }
}
