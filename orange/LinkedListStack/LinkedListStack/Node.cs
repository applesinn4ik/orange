using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStack
{
    class Node<T>
    {
        public int Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
