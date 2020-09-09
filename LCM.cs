using System;


namespace GCD_EuclidianAlgorithm
{
    class LCM
    {
        // LCM(num1, num2) = (num1 * num2)/HCF(num1,num2)
       
        public int LeastCommonMultiple(int num1, int num2)
        {
            int hcf = GreatestCommonFactor(num1, num2); //or Greatest Common Divisor : tip: use Euclidean's algorithm
            int product = num1 * num2;

            int lcm = product / hcf;

            return lcm;
        }
        private int GreatestCommonFactor(int num1, int num2) //Implementing Euclidean's algorithm
        {
            if (num1 > num2)
            {
                //swap
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            while (num2 != 0)
            {
                int rem = num1 % num2;
                num1 = num2;
                num2 = rem;
            }

            int hcf = num1;

            return hcf;
        }
    }
}
