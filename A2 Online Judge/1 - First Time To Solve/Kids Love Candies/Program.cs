using System;

namespace Kids_Love_Candies
{
	class Program
	{
		static void Main(string[] args)
		{
			int T = int.Parse(Console.ReadLine());
			int[] sum = new int[T];
			for (int i = 0; i < T; i++)
			{
				string[] str1 = Console.ReadLine().Split(' ');
				string[] str2 = Console.ReadLine().Split(' ');
				for (int j = 0; j < int.Parse(str1[0]); j++)
				{
					sum[i] += int.Parse(str2[j]) / int.Parse(str1[1]);
				}
			}
			Console.Clear();
			for (int i = 0; i < T; i++)
			{
				Console.WriteLine(sum[i]);
			}
			Console.ReadLine();
		}
	}
}
