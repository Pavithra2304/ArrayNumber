using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraypgm
{
	class Program
	{
		public static void  PositiveNo()
		{
			int[] num;
			Console.WriteLine("How many numbers do you want to enter:");
			int n = Convert.ToInt32(Console.ReadLine());
			num = new int[n];
			for(int i=0;i<n;i++)
			{
				num[i] = Convert.ToInt32(Console.ReadLine());
			}
			int res = Array.FindAll(num, x => x >= 0).Length;
			Console.WriteLine("No.of positive numbers present in the array:" + res);
		}
		static void Main(string[] args)
		{
			PositiveNo();
		}
	}
}
