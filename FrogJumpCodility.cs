using System;

namespace FrogJumpCodility
{
    class Program
    {
        static int FrogJump(int start, int end, int jump)
        {
            int count = 0;
            while (start < end)
            {
                count++;
                start = start + jump;
            }
            return count;
        }
        static int FrogJump2(int start, int end, int jump)
        {
            return (int)Math.Ceiling(((decimal)end - start) / jump);
            
            
        }
        static void Main(string[] args)
        {
            int start = 10;
            int end = 85;
            int jump = 30;
            int result = FrogJump(start, end, jump);
            int result2 = FrogJump2(start, end, jump);
            Console.WriteLine("It takes {0} jumps||| {1} jump", result, result2);
        }
    }
}
