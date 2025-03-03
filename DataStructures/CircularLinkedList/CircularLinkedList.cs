using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.CircularLinkedList
{
    internal class CircularLinkedList
    {
        private Node head;

        // Insert at the end
        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                head.Next = head; // Circular reference
                return;
            }

            Node temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Next = head;
        }

        // Insert at the beginning
        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
                return;
            }

            Node temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Next = head;
            head = newNode;
        }

        // Display the circular linked list
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node temp = head;
            do
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            } while (temp != head);
            Console.WriteLine();
        }
    }
}
