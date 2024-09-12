using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public class TwoSum
    {
        /* Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.
        */

        //!SECTION Brute Force Approach
        // Time complexity: O(n²) because for each element, you loop through the rest of the array to find a match.
        // Space complexity: O(1), since no extra space is used other than the input.
        public static int[] BruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return [i, j];
                }
            }
            return [];
        }

        //!SECTION Two Pointer Approach
        // Time complexity: O(n log n) due to sorting.
        // Space complexity: O(n) because we need extra space to store the sorted array.
        public static int[] TwoPointer(int[] nums, int target)
        {
            int[] sortedNums = (int[])nums.Clone();
            Array.Sort(sortedNums);
            int left = 0;
            int right = sortedNums.Length - 1;
            while (left < right)
            {
                int sum = sortedNums[left] + sortedNums[right];
                if (sum == target)
                {
                    int index1 = Array.IndexOf(nums, sortedNums[left]);
                    int index2 = Array.LastIndexOf(nums, sortedNums[right]);

                    return ReturnLowestValueFirst(index1, index2);
                }
                else if (sum < target)
                    left++;
                else
                    right--;
            }
            return [];
        }

        public static int[] ReturnLowestValueFirst(int index1, int index2)
        {
            if (index1 < index2)
                return [index1, index2];
            else
                return [index2, index1];
        }

        //!SECTION Hash Map/Dictionary Approach
        // Time complexity: O(n) because we traverse the list containing n elements only once.
        // Space complexity: O(n) because we store the elements in a dictionary.
        public static int[] HashMap(int[] nums, int target)
        {
            Dictionary<int, int> dict = [];
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                    return [dict[complement], i];
                dict[nums[i]] = i;
            }
            return [];
        }
    }
}