using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public class InsertionSort
    {
        public static int Sort(int[] A, int n)
        {
            for (int j = 1; j < n; j++)
            {
                int key = A[j];
                int i = j - 1;
                while (i >= 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                A[i + 1] = key;
            }
            return 0;
        }

        public static int SortDescending(int[] A, int n)
        {
            for (int j = 1; j < n; j++)
            {
                int key = A[j];
                int i = j - 1;
                while (i >= 0 && A[i] < key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                A[i + 1] = key;
            }
            return 0;
        }
    }
}