using System;

namespace Nth_Smallest_Value
{
	class Program
	{
		static void Main(string[] args)
		{
			int T = int.Parse(Console.ReadLine());
			int[][] min = new int[T][];
			for (int i = 0; i < T; i++)
			{
				min[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
				Array.Sort(min[i]);
			}
			Console.Clear();
			for (int i = 0; i < T; i++)
			{
				Console.WriteLine(min[i][1]);
			}
			Console.ReadLine();
		}
	}
}