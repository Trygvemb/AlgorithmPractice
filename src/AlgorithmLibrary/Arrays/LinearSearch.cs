using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public class LinearSearch
    {
        public static int Search(int[] A, int x)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}