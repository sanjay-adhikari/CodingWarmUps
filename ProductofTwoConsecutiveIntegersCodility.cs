using System;

namespace ProductofTwoConsecutiveIntegers
{
    class Program
    {
        static int ProductofTwoConsecutiveIntegers(int num1, int num2)
        {
            if ((num1 > num2) || (num1 % 2 == 1 || num2 % 2 == 1)) 
                return 0;
            
            int sqNum1 = (int)(Math.Sqrt(num1));
            
            if (sqNum1 * (sqNum1 + 1) == num1)
            {
                int sqNum2 = (int)(Math.Sqrt(num2));
                if (sqNum2 * (sqNum2 + 1) == num2)
                {
                    return (sqNum2 - sqNum1 + 1);
                }
            }
            return 0;
        }
        
        static bool Pronic_check(int n) //Extra Help-->if someone wants to know how to check Pronic
        {
            int x = (int)(Math.Sqrt(n));

            // Checking Pronic Number by  
            // multiplying consecutive numbers 
            if (x * (x + 1) == n)
                return true;
            else
                return false;
        }
        


        static void Main(string[] args)
        {
            int A = 6;
            int B = 20;
            Console.WriteLine("Output is {0}", ProductofTwoConsecutiveIntegers(A,B));
        }
    }
}
