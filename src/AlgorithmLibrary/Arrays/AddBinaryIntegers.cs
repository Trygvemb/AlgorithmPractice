namespace AlgorithmLibrary;

public class AddBinaryIntegers
{
    public static int[] AddBinary(int[] A, int[] B)
    {
        int n = A.Length;
        int[] C = new int[n + 1];
        int carry = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            int sum = A[i] + B[i] + carry;
            C[i + 1] = sum % 2;
            carry = sum / 2;
        }

        C[0] = carry;
        return C;
    }

    public static int[] AddBinaryWithDifferentLengths(int[] A, int[] B)
    {
        int n = A.Length;
        int m = B.Length;
        int[] C = new int[Math.Max(n, m) + 1];
        int carry = 0;

        for (int i = n - 1, j = m - 1, k = C.Length - 1; k >= 0; i--, j--, k--)
        {
            int sum = (i >= 0 ? A[i] : 0) + (j >= 0 ? B[j] : 0) + carry;
            C[k] = sum % 2;
            carry = sum / 2;
        }

        return C;
    }
}