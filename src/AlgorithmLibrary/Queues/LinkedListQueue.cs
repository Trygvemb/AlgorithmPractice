using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmLibrary.Queues
{
    public class LinkedListQueue
    {
        internal class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }

        Node front, rear;

        public LinkedListQueue()
        {
            this.front = this.rear = null;
        }

        public void Enqueue(int item)
        {
            Node temp = new Node(item);

            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            this.rear.next = temp;
            this.rear = temp;
        }

        public int Dequeue()
        {
            if (this.front == null)
                return int.MinValue;

            Node temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
                this.rear = null;

            return temp.data;
        }

        public int Front()
        {
            if (this.front == null)
                return int.MinValue;

            return this.front.data;
        }

        public int Rear()
        {
            if (this.rear == null)
                return int.MinValue;

            return this.rear.data;
        }

        public bool IsEmpty()
        {
            return this.front == null;
        }

        public bool IsFull()
        {
            return false;
        }

        public List<int> GetQueueElements()
        {
            List<int> elements = new List<int>();
            Node temp = this.front;
            while (temp != null)
            {
            elements.Add(temp.data);
            temp = temp.next;
            }
            return elements;
        }
    }
}