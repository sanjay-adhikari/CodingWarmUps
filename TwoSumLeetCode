using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumLeetCode
{
    class Program
    {
        internal static int[] TwoSum(int[] nums, int target)
        {
            int[] ret = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int count = 0;
            foreach (int x in nums)
            {
                int comp = target - x;
                if (dict.ContainsValue(comp))
                {
                    ret[1] = count;
                    ret[0] = dict.Values.ToList().IndexOf(comp);
                    return ret;
                }
                dict.Add(count, x);
                count++;
            }
            return ret;

        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            DisplayArray(nums, target);

            var result = TwoSum(nums, target);
            DisplayResult(nums, result);
            
            Console.ReadKey();
        }
        static void DisplayArray(int[] nums, int target) {
            Console.WriteLine("The input array is: ");
            foreach (var v in nums)
                Console.Write(v + " ");

            Console.WriteLine("\nTarget: " + target);
            Console.WriteLine("-----------------------------");
        }
        static void DisplayResult(int[] nums, int[] result) {
            Console.WriteLine("The result is: ");
            foreach (var v in result)
                Console.WriteLine(v + " : " + nums[v]);
        }

    }
}
