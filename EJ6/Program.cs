using System;

namespace EJ6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int suma = 0;
			int contador = 0;
			for (int i = 0; i <= 100; i++) {
				if (i % 2 != 0) {
					suma += i;
					contador += 1;
				}
			}
			Console.WriteLine (suma);
			Console.WriteLine (suma / contador);
		}
	}
}
