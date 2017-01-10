using System;
using System.Linq;

namespace Arabic_and_English
{
	class Program
	{
		static void Main(string[] args)
		{
			int T = int.Parse(Console.ReadLine());
			string[][] str = new string[T][];
			for (int i = 0; i < T; i++)
			{
				int num = int.Parse(Console.ReadLine());
				string temp = Console.ReadLine().ToLower();
				str[i] = temp.Split(' ');
				int count = 0;
				for (int j = 0; j < temp.Length; j++)
				{
					if (temp[j] == '#' || temp[j] == ' ')
					{
						++count;
					}
				}
				if (count != temp.Length)
				{
					string[] concat = new string[num];
					int target = 0;
					for (; target < str[i].Length && str[i][target].Contains('#') && target <= num; target++) ;
					int current = 0;
					for (int j = target + 1; j < num; j++, current++)
					{
						concat[current] = str[i][j];
					}
					concat[current] = str[i][target];
					for (int j = 0; j < target; j++)
					{
						concat[++current] = str[i][j];
					}
					str[i] = concat;
				}
			}
			Console.Clear();
			for (int i = 0; i < T; i++)
			{
				for (int j = 0; j < str[i].Length; j++)
				{
					if (j == str[i].Length - 1)
					{
						Console.WriteLine(str[i][j]);
					}
					else
					{
						Console.Write(str[i][j] + " ");
					}
				}
			}
			Console.ReadLine();
		}
	}
}