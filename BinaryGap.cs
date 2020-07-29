using System;

class Solution {
    public int solution(int N) {
        string num = Convert.ToString(N, 2);
        if (string.IsNullOrEmpty(num)) return 0;
            bool firstfound = false;
            int totalGap = 0, oneIndex = 0;
            if (num.Contains("0") && num.Contains("1"))
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] == '1')
                    {
                        if (!firstfound)
                        {
                            firstfound = true;
                            oneIndex = i;
                            continue;
                        }
                        int curGap = i - oneIndex - 1;
                        oneIndex = i;
                        totalGap = Math.Max(totalGap, curGap);
                    }
                }
            }
            return totalGap;
    }
}
