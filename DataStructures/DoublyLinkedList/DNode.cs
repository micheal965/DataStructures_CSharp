using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DoublyLinkedList
{
    public class DNode
    {
        public int Data;
        public DNode Next;
        public DNode Prev;

        public DNode(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
