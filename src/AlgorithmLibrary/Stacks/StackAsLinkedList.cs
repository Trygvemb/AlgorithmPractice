using System;

namespace AlgorithmLibrary.Stacks
{
    public class StackAsLinkedList
    {
        StackNode root;

        public class StackNode
        {
            public int data;
            public StackNode next;

            public StackNode(int data)
            {
                this.data = data;
            }
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Push(int data)
        {
            StackNode newNode = new StackNode(data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                StackNode temp = root;
                root = newNode;
                newNode.next = temp;
            }
        }

        public int Pop()
        {
            if (root == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            int popped = root.data;
            root = root.next;
            return popped;
        }

        public int Peek()
        {
            if (root == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return root.data;
        }

        public void PrintStack()
        {
            if (root == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            StackNode temp = root;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
