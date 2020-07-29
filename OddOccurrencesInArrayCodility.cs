using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrencesInArray
{
    class Program
    {
        static int GetOddOccurrencesInArray(int[] num)
        {
            Dictionary<int,int> dict = new Dictionary<int, int>();
            foreach (int n in num)
            {
                if (dict.ContainsKey(n))
                {
                    dict[n]++;
                }
                else
                {
                    dict.Add(n, 1);
                }
            }
            var oddVal = dict.FirstOrDefault(x => x.Value == 1).Key; //Get Value from Key using Lambda expression
            return oddVal;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            int oddValue = GetOddOccurrencesInArray(nums);

            Display("Input", nums);
            Console.WriteLine("The odd occurence is {0}", oddValue);

        }
        static void Display(string s, int[] num)
        {
            Console.WriteLine("{0}:", s);
            foreach (var n in num)
                Console.Write("{0} \t", n);
            Console.WriteLine("\n");
        }
    }
}
