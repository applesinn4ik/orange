using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStack
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }
    }

    public class LinkedList<T> : ICollection<T>
    {
        public LinkedListNode<T> Head
        {
            get;
            private set;
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;
            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public int Count { get; set; }

        public LinkedListNode<T> Tail { get; set; }
    }

    public void AddFirst(T node)
    {
    AddFirst(new LinkedListNode<T> (node));
    }

public void AddLast(LinkedListNode<T> node)
{
    if (Count == 0)
    {
        Head = node;
    }
    else
    {
        Tail.Next = node;
    }
    Tail = node;
    Count++;
}

public void Add(T item)
{
    AddFirst(item);
}
