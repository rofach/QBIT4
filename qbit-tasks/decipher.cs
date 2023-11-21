using System;

class Program
{
	static void Main()
	{
		int length = int.Parse(Console.ReadLine());
		string str = Console.ReadLine();
		for (int i = 0; i < length; i++)
		{
			Console.Write((int)(str[i]) + " ");


		}
		

	}
}