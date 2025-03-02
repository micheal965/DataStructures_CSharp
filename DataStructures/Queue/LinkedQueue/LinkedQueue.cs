using System;

namespace DataStructures.Queue.LinkedQueue
{
    public class LinkedQueue
    {
        private Node _front; // Points to the front of the queue
        private Node _rear;  // Points to the rear of the queue
        private static int _size;
        public LinkedQueue()
        {
            _front = _rear = null; // Queue is initially empty
            _size = 0;
        }

        // Enqueue (Add an item to the queue)
        public void Enqueue(int item)
        {
            Node newNode = new Node(item);
            if (IsEmpty()) // If queue is empty
            {
                _front = _rear = newNode;
                _size++;
                return;
            }

            _rear.NEXT = newNode; // Link the old rear to the new node
            _rear = newNode; // Update the rear to the new node
            _size++;
        }

        // Dequeue (Remove and return the front item)
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue underflow");
            }

            int dequeuedItem = _front.item;
            _front = _front.NEXT; // Move front to the next node

            if (_front == null) // If queue becomes empty, update rear to null
            {
                _rear = null;
                _size = 0;
            }
            _size--;
            return dequeuedItem;
        }

        // Peek at the front item without removing it
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return _front.item;
        }

        // Check if the queue is empty
        public bool IsEmpty() => _size == 0;

        // Print the queue (for visualization)
        public void PrintQueue()
        {
            Node current = _front;
            while (current != null)
            {
                Console.Write(current.item + " ");
                current = current.NEXT;
            }
            Console.WriteLine();
        }
    }
}
