using System;

namespace BinarySearchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { -1, 0, 3, 5, 9, 12 };
            int searchValue = 19;
            Console.WriteLine("{0} is found at index {1}", searchValue, BinarySearch(numbers, searchValue));
            Console.ReadKey();
        }
        public static int BinarySearch(int[] nums, int target) //Iterative approach
        {
            int midIndex, leftIndex = 0, rightIndex=nums.Length-1;
            while (leftIndex <= rightIndex)
            {
                midIndex = leftIndex + (rightIndex - leftIndex) / 2;
                if (nums[midIndex] == target) 
                    return midIndex; //This is what we are looking for
                
                if (target < nums[midIndex]) 
                    rightIndex = midIndex - 1;
                else 
                    leftIndex = midIndex + 1;
            }
            return -1;
        }
        
        public static int BinarySearchRecursive(int[] nums, int low, int high, int key) //Using Recursive Approach
        {
            if(low == high)
            {
                if(nums[low] == key)
                    return low;
                else
                    return -1;
            }
            else
            {
                int mid = (low + high) /2;
                
                if(key == nums[mid])
                    return mid;
                
                if(key < nums[mid])
                    return BinarySearchRecursive(nums, low, mid -1, key);
                else
                    return BinarySearchRecursive(nums, mid + 1, high, key);
            }
        }
    }
}
