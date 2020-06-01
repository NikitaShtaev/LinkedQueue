using System;
using System.Globalization;

namespace LessonTrainer.Model
{
    class LinkedQueue<T>
    {
        private Item<T> Head;
        private Item<T> Tail;
        public int count { get; private set; }
        public LinkedQueue() { }
        public LinkedQueue(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            count = 1;
        }

        public void Enqueue(T data)
        {
            if (count ==0)
            {
                SetHeadItem(data);
                return;
            }
            var item = new Item<T>(data)
            {
                Next = Tail
            };
            Tail = item;
            count++; 
        }
        public T Dequeue()
        {
            var data = Head.Data;
            var current = Tail.Next;
            var previous = Tail;
            while (current != null && current.Next!= null)
            {
                previous = current;
                current = current.Next;
            }
            Head = previous;
            Head.Next = null;
            count--;
            return data;

        }
        public T Peek()
        {
            return Head.Data;
        }
    }
}
