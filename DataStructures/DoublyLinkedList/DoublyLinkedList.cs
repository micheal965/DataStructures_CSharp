using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DoublyLinkedList
{

    class DoublyLinkedList
    {
        private DNode head;
        // Insert at the end
        public void InsertAtEnd(int data)
        {
            DNode newNode = new DNode(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            DNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Prev = temp;
        }

        // Insert at the beginning
        public void InsertAtBeginning(int data)
        {
            DNode newNode = new DNode(data);
            if (head != null)
            {
                newNode.Next = head;
                head.Prev = newNode;
            }
            head = newNode;
        }

        // Insert at a specific position (0-based index)
        public void InsertAtPosition(int data, int position)
        {
            if (position == 0)
            {
                InsertAtBeginning(data);
                return;
            }

            DNode newNode = new DNode(data);
            DNode temp = head;
            for (int i = 0; temp != null && i < position - 2; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Position out of bounds!");
                return;
            }

            newNode.Next = temp.Next;
            newNode.Prev = temp;

            if (temp.Next != null)
            {
                temp.Next.Prev = newNode;
            }

            temp.Next = newNode;
        }

        // Delete a node by value
        public void Delete(int key)
        {
            if (head == null)
                return;

            DNode temp = head;

            // If the head needs to be deleted
            if (head.Data == key)
            {
                head = head.Next;
                if (head != null)
                    head.Prev = null;
                return;
            }

            while (temp != null && temp.Data != key)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Key not found!");
                return;
            }

            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;

            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;
        }

        // Display the list forward
        public void DisplayForward()
        {
            DNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        // Display the list backward
        public void DisplayBackward()
        {
            if (head == null)
                return;

            DNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Prev;
            }
            Console.WriteLine();
        }
    }
}
