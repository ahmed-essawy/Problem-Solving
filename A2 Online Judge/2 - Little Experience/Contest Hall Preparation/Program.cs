using System;
using System.Collections.Generic;
using System.Linq;

namespace Contest_Hall_Preparation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[][,] nums = new int[T][,];
            int[] counters = new int[T];
            for (int i = 0; i < T; i++)
            {
                int[] dim = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                nums[i] = new int[dim[0], dim[1]];
                for (int x = 0; x < nums[i].GetLength(0); x++)
                {
                    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    for (int y = 0; y < nums[i].GetLength(1); y++)
                    {
                        nums[i][x, y] = arr[y];
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < T; i++)
            {
                HashSet<int> list = new HashSet<int>();
                for (int x = 0, x_len = nums[i].GetLength(0); x < x_len; x++)
                {
                    for (int y = 0, y_len = nums[i].GetLength(1); y < y_len; y++)
                    {
                        if (nums[i][x, y] != -1)
                        {
                            if (x > 0)
                            {
                                if (y > 0)
                                    if (nums[i][x, y] == nums[i][x - 1, y - 1]) { list.Add(nums[i][x, y]); }
                                if (nums[i][x, y] == nums[i][x - 1, y]) { list.Add(nums[i][x, y]); }
                                if (y < y_len - 1)
                                    if (nums[i][x, y] == nums[i][x - 1, y + 1]) { list.Add(nums[i][x, y]); }
                            }

                            if (y > 0)
                                if (nums[i][x, y] == nums[i][x, y - 1]) { list.Add(nums[i][x, y]); }
                            if (y < y_len - 1)
                                if (nums[i][x, y] == nums[i][x, y + 1]) { list.Add(nums[i][x, y]); }

                            if (x < x_len - 1)
                            {
                                if (y > 0)
                                    if (nums[i][x, y] == nums[i][x + 1, y - 1]) { list.Add(nums[i][x, y]); }
                                if (nums[i][x, y] == nums[i][x + 1, y]) { list.Add(nums[i][x, y]); }
                                if (y < y_len - 1)
                                    if (nums[i][x, y] == nums[i][x + 1, y + 1]) { list.Add(nums[i][x, y]); }
                            }
                        }
                    }
                }
                Console.WriteLine(list.Count());
            }
            Console.ReadKey();
        }
    }
}