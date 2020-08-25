using System;
using System.Collections.Generic;
using System.Linq;

namespace HR2DArrayHourGlass
{
    class Program
    {
        private static int HourglassSum(int[][] arr)
        {
            List<int> sums = new List<int>();

            int max = 0;

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    int sum = arr[i-1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1]
                                            + arr[i][j] +
                              arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    sums.Add(sum);

                    max = Math.Max(max, sum);
                }
            }

            foreach (var s in sums)
                Console.Write("{0} \t", s);


            return sums.Max();
        }
        static void Main(string[] args)
        {
            //jagged array
            int[][] arr = new int[6][] {
                new int[] {1, 1, 1, 0, 0, 0},
                new int[]{ 0, 1, 0, 0, 0, 0 },
                new int[]{ 1, 1, 1, 0, 0, 0},
                new int[]{ 0, 0, 2, 4, 4, 0},
                new int[]{ 0, 0, 0, 2, 0, 0},
                new int[]{ 0, 0, 1, 2, 4, 0 }
            };
                

            int result = HourglassSum(arr);

            Console.WriteLine("\n\nThe hourglass with the maximum sum is {0}", result);

            Console.ReadKey();

        }

        
    }
}
