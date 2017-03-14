using System;

namespace Nth_Smallest_Value
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[][] nums = new int[T][];
            for (int i = 0; i < T; i++)
            {
                nums[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Array.Sort(nums[i]);
            }
            Console.Clear();
            foreach (int[] num in nums)
                Console.WriteLine(num[1]);
            Console.ReadKey();
        }
    }
}