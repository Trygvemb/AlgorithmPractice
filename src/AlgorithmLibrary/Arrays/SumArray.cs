namespace AlgorithmLibrary
{
    public class SumArray
    {
        public static int Sum(int[] A, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + A[i];
            }
            return sum;
        }

    }
}

