using System;
namespace DataStructures.Queue
{
    public class CircularQueue
    {
        private int[] _items;
        private int _front;
        private int _rear;
        private static int _size;
        private int _capacity;

        public CircularQueue(int capacity)
        {
            _capacity = capacity;
            _items = new int[capacity];
            _front = 0;
            _rear = -1;
            _size = 0;
        }

        // Enqueue (Add an item to the queue)
        public void Enqueue(int item)
        {
            if (IsFull())
                throw new InvalidOperationException("Queue overflow");

            _rear = (_rear + 1) % _capacity; // Circular increment
            _items[_rear] = item;
            _size++;
        }
        // Dequeue (Remove and return the front item)
        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow");

            int dequeuedItem = _items[_front];
            _front = (_front + 1) % _capacity; // Circular increment
            _size--;
            return dequeuedItem;
        }

        // Peek at the front item without removing it
        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            return _items[_front];
        }

        // Check if the queue is empty
        public bool IsEmpty() => _size == 0;

        // Get the count of elements in the queue
        public int Count() => _size;

        public bool IsFull() => _size == _capacity;
        // Print the queue (for visualization)
        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            int index = _front;
            for (int i = 0; i < _size; i++)
            {
                Console.Write(_items[index] + " ");
                index = (index + 1) % _capacity; // Circular increment
            }
            Console.WriteLine();
        }
    }
}
