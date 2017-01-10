using System;

namespace Omar
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] sum = new int[int.Parse(Console.ReadLine())];
			for (int i = 0; i < sum.Length; i++)
			{
				foreach (string num in Console.ReadLine().Split(' '))
				{
					sum[i] += int.Parse(num);
				}
			}
			Console.Clear();
			for (int i = 0; i < sum.Length; i++)
			{
				Console.WriteLine(sum[i]);
			}
			Console.ReadLine();
		}
	}
}