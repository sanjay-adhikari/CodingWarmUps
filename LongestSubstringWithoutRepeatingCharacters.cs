using System;
using System.Collections.Generic;
namespace LongestSubstring
{
    class Program
    {
        public static int LengthOfLongestSubstring(string s) //SOLUTION 1: BruteForce- O(N^3)- Must understand this before moving to the O(N) solution
        {
            int totalMax = 0;
            if (string.IsNullOrEmpty(s)) return 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i+1; j <= s.Length; j++)
                {
                    bool isAllUnique = false;
                    List<string> lst = new List<string>();
                    for (int k = i; k < j; k++)
                    {
                        var tVal = s[k].ToString();
                        if (lst.Contains(tVal))
                        {
                            isAllUnique = false;
                            break;
                        }
                        else
                        {
                            isAllUnique = true;
                            lst.Add(tVal);
                        }
                        
                    }
                    if(isAllUnique)
                        totalMax = Math.Max(totalMax, j - i);
                }
            }
            return totalMax;
        }
        static void Main(string[] args)
        {
            var inputs = new string[] { "abcabcbb",
                                     "bbbbb",
                                     "pwwkew",
                                     "c",
                                     "dvdf"
                                    };
            for (int i = 0; i <= inputs.Length-1; i++)
            {
                var inp = inputs[i];
                var op = LengthOfLongestSubstring(inp);
                Console.WriteLine("input = {0} \t Maximum Substring Length: {1} \n", inp,op);
            }
            Console.WriteLine("\n\n---------------------\n\n");
            for (int i = 0; i <= inputs.Length - 1; i++)
            {
                var inp = inputs[i];
                var obj = new LengthOfLongestSubstring2(inp);
                var op = obj.LengthOfLongSubs();
                Console.WriteLine("input = {0} \t Maximum Substring Length: {1} \n", inp, op);
            }
        }
    }
    public class LengthOfLongestSubstring2 //Better Solution- Sliding Window solution
    {
        string s;
        public LengthOfLongestSubstring2(string s1)
        {
            s = s1;
        }
        public int LengthOfLongSubs()
        {
            int n = s.Length;
            List<string> lst = new List<string>();
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                // try to extend the range [i, j]
                var checkString = s[j].ToString();
                if (!lst.Contains(checkString))
                {
                    lst.Add(checkString);
                    j += 1;
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    var removeString = s[i].ToString();
                    lst.Remove(removeString);
                    i++;
                }
            }
            return ans;
        }
    }
}
