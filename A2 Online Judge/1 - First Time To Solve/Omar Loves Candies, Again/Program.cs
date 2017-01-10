using System;
using System.Linq;

namespace Omar_Loves_Candies__Again
{
	class Program
	{
		struct data
		{
			public int num;
			public char ch;
		}
		static void Main(string[] args)
		{
			int T = int.Parse(Console.ReadLine());
			string[] str = new string[T];
			data[] alldata = new data[T];
			for (int i = 0; i < T; i++)
			{
				str[i] = Console.ReadLine().ToLower();
				char[] chars = str[i].Distinct().ToArray();
				data[] temp = new data[chars.Length];
				alldata[i].num = 1;
				alldata[i].ch = chars[0];
				for (int j = 0; j < chars.Length; j++)
				{
					temp[j].ch = chars[j];
					temp[j].num = str[i].Split(chars[j]).Length - 1;
					if (temp[j].num == alldata[i].num && temp[j].ch < alldata[i].ch)
					{
						alldata[i].ch = temp[j].ch;
					}
					if (temp[j].num > alldata[i].num)
					{
						alldata[i].num = temp[j].num;
						alldata[i].ch = temp[j].ch;
					}
				}
			}
			Console.Clear();
			for (int i = 0; i < T; i++)
			{
				Console.WriteLine(alldata[i].num + " " + alldata[i].ch);
			}
			Console.ReadLine();
		}
	}
}