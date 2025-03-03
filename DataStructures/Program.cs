using DataStructures.LinkedList;
using DataStructures.Queue;
using DataStructures.Queue.LinkedQueue;
using DataStructures.Stack;
using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Stack
            //STACK stack = new STACK(10);
            //stack.Push(1);
            //stack.Display();//1
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(5);
            //stack.Display();//5 2 1 1
            //Console.WriteLine(stack.Pop());//5
            //stack.Display();//2 1 1 
            //Console.WriteLine(stack.Pop());//2
            //stack.Display();//1 1 
            //Console.WriteLine(stack.Peek());//1
            //stack.Display();//1 1 
            #endregion
            #region LinkedStack
            //LinkedSTACK stack = new LinkedSTACK();

            //stack.Push(10);//1
            //stack.Push(20);//2
            //stack.Push(30);//3

            //Console.WriteLine("Stack after pushes:");
            //stack.Display(); // 30 -> 20 -> 10
            //Console.WriteLine(stack.Count());
            //Console.WriteLine("Top element: " + stack.Peek()); // 30
            //Console.WriteLine(stack.Count());
            //Console.WriteLine("Popped element: " + stack.Pop()); // 30
            //Console.WriteLine(stack.Count());

            //Console.WriteLine("Stack after pop:");
            //stack.Display(); // 20 -> 10 -> NULL
            #endregion
            #region Queue
            //CircularQueue queue = new CircularQueue(5); // Queue with size 5

            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);

            //Console.WriteLine("Queue after enqueues:");
            //queue.PrintQueue(); // 10 -> 20 -> 30 

            //Console.WriteLine("Front element: " + queue.Peek()); // 10
            //Console.WriteLine("Dequeued element: " + queue.Dequeue()); // 10

            //Console.WriteLine("Queue after dequeue:");
            //queue.PrintQueue(); // 20 -> 30
            #endregion
            #region LinkedQueue
            //LinkedQueue queue = new LinkedQueue();

            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);

            //Console.WriteLine("Queue after enqueues:");
            //queue.PrintQueue(); // 10 -> 20 -> 30 

            //  Console.WriteLine("Front element: " + queue.Peek()); // 10
            //Console.WriteLine("Dequeued element: " + queue.Dequeue()); // 10

            //Console.WriteLine("Queue after dequeue:");
            // queue.PrintQueue(); // 20 -> 30
            #endregion
            #region LinkedList
            //LinkedList.LinkedList list = new LinkedList.LinkedList();
            //list.InsertAtEnd(10);
            //list.InsertAtEnd(20);
            //list.InsertAtEnd(30);
            //list.InsertAtBeginning(5);
            //list.Display(); // Output: 5 -> 10 -> 20 -> 30 

            //list.Delete(20);
            //list.Display(); // Output: 5 -> 10 -> 30 
            #endregion
            #region CircularLinkedList
            //CircularLinkedList.CircularLinkedList list = new CircularLinkedList.CircularLinkedList();
            //list.InsertAtEnd(10);
            //list.InsertAtEnd(20);
            //list.InsertAtEnd(30);
            //list.InsertAtBeginning(5);
            //list.Display(); // Output: 5 -> 10 -> 20 -> 30 
            #endregion
            #region DoublyLinkedList
            DoublyLinkedList.DoublyLinkedList list = new DoublyLinkedList.DoublyLinkedList();

            list.InsertAtEnd(15);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);
            list.InsertAtBeginning(5);
            list.InsertAtPosition(10, 2);

            Console.WriteLine("Forward:");
            list.DisplayForward(); // Output: 5 <-> 10 <-> 15 <-> 20 <-> 30 

            Console.WriteLine("Backward:");
            list.DisplayBackward(); // Output: 30 <-> 20 <-> 15 <-> 10 <-> 5 

            list.Delete(15);
            Console.WriteLine("After Deleting 15:");
            list.DisplayForward(); // Output: 5 <-> 10 <-> 20 <-> 30
            #endregion
        }
    }
}
