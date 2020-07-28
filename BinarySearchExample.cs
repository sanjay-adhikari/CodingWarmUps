using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static int BinarySearch(int[] nums, int target)
        {
            //return Array.IndexOf(nums,target); This is linear
            
            int midIndex, leftIndex = 0, rightIndex=nums.Length-1;
            while (leftIndex <= rightIndex)
            {
                midIndex = leftIndex + (rightIndex - leftIndex) / 2;
                if (nums[midIndex] == target) return midIndex;
                if (target < nums[midIndex]) rightIndex = midIndex - 1;
                else leftIndex = midIndex + 1;
            }
            return -1;
        }
    }
}
