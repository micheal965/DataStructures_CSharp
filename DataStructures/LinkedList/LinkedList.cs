using System;

namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        private Node head;

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void Delete(int key)
        {
            if (head == null) return;

            if (head.item == key)
            {
                head = head.Next;
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.item != key)
            {
                temp = temp.Next;
            }

            if (temp.Next == null) return; // Key not found

            temp.Next = temp.Next.Next;
        }

        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.item + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        public void InsertAtPosition(int data, int position)
        {
            Node newNode = new Node(data);

            if (position == 0) // Insert at head
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            Node temp = head;
            for (int i = 0; temp != null && i < position - 2; i++)
            {

                temp = temp.Next;
            }

            if (temp == null) // Position out of bounds
            {
                Console.WriteLine("Position out of bounds!");
                return;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

    }
}