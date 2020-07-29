using System;

namespace CyclicRightRotationCodilityChallenge
{
    class Program
    {
        public static int[] CyclicRightRotation(int[] nums, int rotateLeftValue)
        {
            int n = nums.Length;
            int[] finalArray = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = (i + rotateLeftValue) % n ;
                finalArray[temp] = nums[i];
            }
            return finalArray;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 3,8,9,7,6};
            int k = 3;
            var result = CyclicRightRotation(a, k);
            Display("Input",a);
            Display("Output",result);

            Console.ReadKey();
        }
        static void Display(string s, int[] num)
        {
            Console.WriteLine("{0}:",s);
            foreach (var n in num)
                Console.Write("{0} \t", n);
            Console.WriteLine("\n");
        }
    }
}
