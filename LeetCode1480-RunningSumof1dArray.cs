using System;
namespace RunningSumof1dArray
{
    public class Program
    {
        public static int[] RunningSum(int[] nums) //Main logic
        {
            int n = nums?.Length ?? 0;
            int[] res = new int[n];
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                res[i] = currentSum;
            }
                
            return res;

        }
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            int[] runSums = RunningSum(nums);
            Console.WriteLine("Input:");
            Display(nums);
            Console.WriteLine("Output:");
            Display(runSums);

            Console.ReadKey();
        }

        public static void Display(int[] nums)
        {
            Console.WriteLine(); 
            for (int i = 0; i < nums.Length; i++)
                Console.Write("{0} \t", nums[i]);
            Console.WriteLine("\n\n");

        }
    }
}
