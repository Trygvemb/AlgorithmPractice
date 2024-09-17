using System;

namespace AlgorithmLibrary.Stacks
{
    public class Stack
    {
        private int[] ele;
        private int top;
        private int max;

        public Stack(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }  

        public void Push(int item)
        {
            IsFull();
            ele[++top] = item;
        }

        public int Pop()
        {
            IsEmpty();
            return ele[top--];
        }

        public int Peek()
        {
            IsEmpty();
            return ele[top];
        }

        public void PrintStack()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.Write(ele[i] + " ");
            }
            Console.WriteLine();
        }

        public void IsFull()
        {
            if (top == max - 1)
            {
                throw new IndexOutOfRangeException("Stack is full");
            }
        }   

        public void IsEmpty()
        {
            if (top == -1)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
        }   
    }
}