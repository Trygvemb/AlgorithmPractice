using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmLibrary.Queues
{
    public class ArrayQueue
    {
        int front, rear, size;
        int capacity;
        int[] array;

        public ArrayQueue(int capacity)
        {
            this.capacity = capacity;
            front = size = 0;
            rear = capacity - 1;
            array = new int[this.capacity];
        }

        public bool IsFull()
        {
            return size == capacity;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
                return;

            rear = (rear + 1) % capacity;
            array[rear] = item;
            size++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                return int.MinValue;

            int item = array[front];
            front = (front + 1) % capacity;
            size--;
            return item;
        }

        public int Front()
        {
            if (IsEmpty())
                return int.MinValue;

            return array[front];
        }

        public int Rear()
        {
            if (IsEmpty())
                return int.MinValue;

            return array[rear];
        }

        public List<int> GetQueueElements()
        {
            List<int> elements = new List<int>();
            if (IsEmpty())
            return elements;

            for (int i = 0; i < size; i++)
            {
            int index = (front + i) % capacity;
            elements.Add(array[index]);
            }
            return elements;
        }
    }
}