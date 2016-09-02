using System;

namespace EJ7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float pi = 0;
			int contador = 0;

			// Calcula PI y muestra como va la comparación.

			do {
				pi += (float)(Math.Pow(-1, contador)) / (2*contador + 1);	
				Console.WriteLine(pi*4 + " != " + (float)Math.PI);
				contador += 1;	
		
			} while (pi != (float)Math.PI/4);

			Console.WriteLine("n = " + contador);
		}
	}
}
