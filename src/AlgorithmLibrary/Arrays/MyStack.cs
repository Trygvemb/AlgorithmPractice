using System.Runtime.Intrinsics.X86;

namespace AlgorithmLibrary.Arrays
{
    public class MyStack
    {
        private int[] arr;
        private int top;
        
        public MyStack()
        {
            arr = new int[1000];
            top = -1;
        }

        public void Push(int x)
        {
            arr[++top] = x;
        }

        public int Pop()
        {
            if (top == -1)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
            return arr[top--];
        }
    }
}