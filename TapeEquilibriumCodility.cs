using System;
using System.Linq;

namespace TapeEquilibriumCodility
{
    class Program
    {
        public static int TapeEquilibrium(int[] num)
        {
            int sum = num.Sum();
            int min = Int32.MaxValue;
            int leftVal = 0;
            for (int i = 0; i < num.Length-1; i++)
            {
                leftVal = num[i] + leftVal;
                int diff = Math.Abs(sum - 2* leftVal);
                min = Math.Min(min, diff);
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3,1,2,4,3 };
            var res = TapeEquilibrium(nums);
            Console.WriteLine("The minimum differenc is {0}", res);

        }
    }
}
