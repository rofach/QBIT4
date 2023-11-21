using System;

class Program
{
	static void Main()
	{
		int length = int.Parse(Console.ReadLine());
		string[] str = Console.ReadLine().Trim().Split();
		for (int i = 0; i < length; i++)
		{
		
			int a = int.Parse(str[i]);
			Console.Write(Convert.ToChar(a));


		}
		

	}
}