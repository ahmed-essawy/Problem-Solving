using System;

namespace Balloon_Colors
{
	class Program
	{
		static void Main(string[] args)
		{
			int T = int.Parse(Console.ReadLine());
			string[][] str1 = new string[T][];
			string[] data = new string[T];
			for (int i = 0; i < T; i++)
			{
				str1[i] = Console.ReadLine().Split(' ');
				string[] str2 = Console.ReadLine().Split(' ');
				if (str1[i][1] == str2[0] && str1[i][2] == str2[int.Parse(str1[i][0]) - 1])
				{
					data[i] = "BOTH";
				}
				else if (str1[i][1] == str2[0] && str1[i][2] != str2[int.Parse(str1[i][0]) - 1])
				{
					data[i] = "EASY";
				}
				else if (str1[i][1] != str2[0] && str1[i][2] == str2[int.Parse(str1[i][0]) - 1])
				{
					data[i] = "HARD";
				}
				else if (str1[i][1] != str2[0] && str1[i][2] != str2[int.Parse(str1[i][0]) - 1])
				{
					data[i] = "OKAY";
				}
			}
			Console.Clear();
			for (int i = 0; i < T; i++)
			{
				Console.WriteLine(data[i]);
			}
			Console.ReadLine();
		}
	}
}