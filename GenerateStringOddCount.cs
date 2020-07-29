using System;
using System.Linq;
using System.Text;

namespace GenerateStringOddCount
{
    class Program
    {
        public static string Repeat(int n) //100% faster solution- most efficient 
        {
            StringBuilder sb = new StringBuilder();
            bool isOdd = false;
            if (n % 2 == 1) isOdd = true;
            if (!isOdd) n -= 1;
            for (int i = 0; i < n; i++)
                sb.Append("a");
            if (!isOdd) sb.Append("b");

            return sb.ToString();

        }
        static string GenerateStringOdd2(int n)
        {
            string s = string.Empty;
            if (n % 2 == 0)
            {
                s = "b";
                n = n - 1;
            } 
            s = s + string.Concat(Enumerable.Repeat("a", n));
            return s;
        }
        static string GenerateStringOdd(int n)
        {
            string s = string.Empty;
            
            if (n % 2 == 0)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    s += "a";
                }
                s += "b";
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    s += "a";
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            int n = 4;
            var result = GenerateStringOdd(n);
            var result2 = GenerateStringOdd2(n);
            Console.WriteLine("For n={0} \t string is {1} \t {2} \t {3}", n, result, result2, Repeat(n));
        }
    }
}
