using System;

namespace AlgorithmLibrary
{
    public class MissingElementFinder
    {
        public static int FindMissingElement(int n, int[] arr)
        {
            // Calculate the sum of the first n natural numbers
            int totalSum = n * (n + 1) / 2;

            // Calculate the sum of the elements in the array
            int arraySum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arraySum += arr[i];
            }

            // The missing element is the difference between the total sum and the array sum
            return totalSum - arraySum;
        }
    }
}