namespace AlgorithmLibrary.Test
{
    public class TwoSumTest
    {
        //!SECTION Brute Force Tests
        [Fact]
        public void BruteForceTest1()
        {
            int[] nums = [2, 7, 11, 15, 3, 6];
            int target = 14;
            int[] expected = [2, 4];
            Assert.Equal(expected, TwoSum.BruteForce(nums, target));
        }

        [Fact]
        public void BruteForceTest2()
        {
            int[] nums = [3, 2, 4];
            int target = 6;
            int[] expected = [1, 2];
            Assert.Equal(expected, TwoSum.BruteForce(nums, target));
        }

        [Fact]
        public void BruteForceTest3()
        {
            int[] nums = [3, 3];
            int target = 6;
            int[] expected = [0, 1];
            Assert.Equal(expected, TwoSum.BruteForce(nums, target));
        }

        //!SECTION Two Pointer Test
        [Fact]
        public void TwoPointerTest1()
        {
            int[] nums = [2, 7, 11, 15, 3, 6];
            int target = 14;
            int[] expected = [2, 4];
            Assert.Equal(expected, TwoSum.TwoPointer(nums, target));
        }

        [Fact]
        public void TwoPointerTest2()
        {
            int[] nums = [3, 2, 4];
            int target = 6;
            int[] expected = [1, 2];
            Assert.Equal(expected, TwoSum.TwoPointer(nums, target));
        }

        [Fact]
        public void TwoPointerTest3()
        {
            int[] nums = [3, 3];
            int target = 6;
            int[] expected = [0, 1];
            Assert.Equal(expected, TwoSum.TwoPointer(nums, target));
        }

        //!SECTION Hash Map Test
        [Fact]
        public void HashMapTest1()
        {
            int[] nums = [2, 7, 11, 15, 3, 6];
            int target = 14;
            int[] expected = [2, 4];
            Assert.Equal(expected, TwoSum.HashMap(nums, target));
        }

        [Fact]
        public void HashMapTest2()
        {
            int[] nums = [3, 2, 4];
            int target = 6;
            int[] expected = [1, 2];
            Assert.Equal(expected, TwoSum.HashMap(nums, target));
        }

        [Fact]
        public void HashMapTest3()
        {
            int[] nums = [3, 3];
            int target = 6;
            int[] expected = [0, 1];
            Assert.Equal(expected, TwoSum.HashMap(nums, target));
        }
    }
}