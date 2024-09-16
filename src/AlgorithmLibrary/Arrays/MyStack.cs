using System.Runtime.Intrinsics.X86;

namespace AlgorithmLibrary.Arrays
{
    public class MyStack
    {
        private int[] Arr;
        private int top;
        
        public MyStack()
        {
            int[] Arr = new int[1000];
            int top = -1;
        }

        public void Push(int x)
        {
            Arr[++top] = x;
        }

        public int Pop()
        {
            return Arr[top--];
        }
    }
}