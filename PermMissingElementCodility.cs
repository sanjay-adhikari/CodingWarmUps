using System;
using System.Linq;

namespace PermMissingElementCodility
{
    class Program
    {
        static int PermMissingElem(int[] num)
        {
            #region Alorithm
            /*
                Calculate the sum of first n natural numbers as sumtotal= n*(n+1)/2
                create a variable sum to store the sum of array elements.
                Traverse the array from start to end.
                Update the value of sum as sum = sum + array[i]
                print the missing number as sumtotal – sum
             */
            #endregion

            int n = num.Length;
            int total = (n + 1) * (n + 2) / 2; //N = n + 1 as one is missing

            for (int i = 0; i < n; i++)
                total -= num[i];

            return total;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 4, 5, 6 };
            int miss = PermMissingElem(a);
            Console.Write(miss);

        }
    }
}
