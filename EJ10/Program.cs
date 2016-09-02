using System;

namespace EJ10
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Algoritmo de años bisiestos obtenido de https://support.microsoft.com/es-ar/kb/214019
			for (int i = 1900; i < 2016; i++) {
				if (i % 4 == 0) {
					if (i % 100 == 0) {
						if (i % 400 == 0) {
							Console.WriteLine (i);
						}
					} else
						Console.WriteLine (i);	
				}
			}
		}
	}
}
