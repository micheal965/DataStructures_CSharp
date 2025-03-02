using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue.LinkedQueue
{
    public class Node
    {
        public int item;
        public Node NEXT;
        public Node(int item)
        {
            this.item = item;
            NEXT = null;
        }
    }
}
