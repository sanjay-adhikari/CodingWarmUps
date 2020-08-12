using System;

namespace KadaneAlgorithm
{
    class Program
    {
        public static int CheckSubarraySum(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int totalMax = int.MinValue;
            int localMax = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                localMax = Math.Max(localMax + nums[i], nums[i]);

                totalMax = Math.Max(totalMax, localMax);
            }


            return totalMax;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var ans = CheckSubarraySum(a);

            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
