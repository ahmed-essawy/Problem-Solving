using System;

namespace Day_1___Data_Types
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            int i2 = int.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
            string s2 = Console.ReadLine();

            Console.WriteLine(i + i2);
            Console.WriteLine("{0:F1}", d + d2);
            Console.WriteLine(s + s2);
        }
    }
}