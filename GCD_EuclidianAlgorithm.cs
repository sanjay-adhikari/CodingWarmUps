using System;

namespace GCD_EuclidianAlgorithm
{
    class Program
    {
        /// <summary>
        /// 
        /// Precondition: two positive integers num1 and num2
        /// Postcondition: the greatest common integer divisor of num1 and num2
        /// 
        /// largeNumber = small number * quotient + remainder (general trick)
        /// 
        /// if num1<num2, swap(num1, num2)
        /// while num2 does not equal 0
        ///   remainder = num1 mod num2
        ///   num1 = num2
        ///   num2 = remainder
        ///endwhile
        ///output num1 = GCD
        ///
        /// </summary>
        static int GCD(int num1, int num2) //Method 1
        {
            if (num1 < num2)
                Swap(ref num1, ref num2);


            while (num2 != 0)
            {
                var rem = num1 % num2;
                num1 = num2;
                num2 = rem;
            }

            return num1;
        }

        static int GCD_Recursive(int num1, int num2) //Method 2: Using Recursive Method
        {
            if (num2 == 0)
                return num1;
            else
            {
                int rem = num1 % num2;
                num1 = num2;
                return GCD_Recursive(num1, rem);
            }
               
        }

        static int GCD_Array(int[] nums) //For array of integers - using same algorithm
        {
            int gcd = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int num1 = nums[i];
                int num2 = nums[i + 1];

                if (num1 < num2)
                    Swap(ref num1, ref num2);

                while (num2 != 0)
                {
                    int rem = num1 % num2;
                    num1 = num2;
                    num2 = rem;
                }

                gcd = num1;
            }
            return gcd;
        }

        static void Main(string[] args)
        {
            int n1 = 10; int n2 = 45;
            var gcd = GCD(n1,n2);
            Console.WriteLine("GCD of {0} and {1} is {2}", n1, n2, gcd);
        }

        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
