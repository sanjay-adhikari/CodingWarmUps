using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_39_CombinationSum
{
    class Program
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates); 
            IList<IList<IList<int>>> results = new List<IList<IList<int>>>();

            for (int i = 1; i <= target; i++) 
            { 
                IList<IList<int>> mainList = new List<IList<int>>(); 

                Console.WriteLine("\n\nAt i = " + i);

                for (int j = 0; j < candidates.Length; j++)
                {
                    var currCandidate = candidates[j];

                    Console.WriteLine("candidates[{0}] = {1} ", j, currCandidate);

                    if (currCandidate <= i)
                    {
                        if (i == candidates[j]) 
                        {
                            Console.WriteLine("\tcurrCandidate = i");

                            mainList.Add(new List<int>() { candidates[j] });
                            continue;
                        }

                        var indexResult = i - currCandidate - 1;

                        Console.WriteLine("\tcurrCandidate <= i");
                        Console.WriteLine("\tResult Index = {0}", indexResult);

                        foreach (var result in results[indexResult])
                        {
                            if (currCandidate <= result[0])
                            {
                                List<int> tempLst = new List<int>();

                                tempLst.Add(currCandidate);
                                tempLst.AddRange(result);

                                mainList.Add(tempLst);
                            }
                        }
                    }
                }
                results.Add(mainList);
            }
            return results[target - 1];

        }
        public static IList<IList<int>> CombinationSum1(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            var visitedValue = new List<int>();

            var valueLessThanOrEqualToTarget = candidates.Where(c => c <= target);
            foreach (var c in candidates)
            {
                if (c == target)
                    result.Add(new List<int>() { c });

                if (!visitedValue.Any())
                    visitedValue.Add(c); //add to the list for the first time
                
                int tempCount = c;
                for(int i = 0; i<visitedValue.Count;i++)
                {
                    tempCount = tempCount + visitedValue[i];
                    if (tempCount == target)
                    {
                        result.Add(new List<int>() { c });
                    }
                }
            }

            return result;
        }
        static void Main(string[] args)
        {

            var candidate = new int[] { 2, 3, 6, 7 };
            var target = 7;

            Console.WriteLine("Input Array:\n ");
            foreach (var c in candidate)
                Console.Write("{0}\t", c);

            var results = CombinationSum(candidate, target);

            Console.WriteLine("\n\nOutput:\n ");
            int i = 0;
            foreach (var result in results)
            {
                Console.WriteLine("\nPossible Combination {0}:\n", i);
                foreach (var res in result)
                    Console.WriteLine("{0}", res);
            }


            Console.ReadKey();
        }
    }
}
