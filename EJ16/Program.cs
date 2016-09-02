using System;
using System.Collections.Generic;

namespace EJ16
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string palabra1, palabra2 = "";

			Console.Write ("Ingrese primera palabra: ");
			palabra1 = Console.ReadLine ().ToLower();
			Console.Write ("Ingrese segunda palabra: ");
			palabra2 = Console.ReadLine ().ToLower();

			/// Contados son las posiciones de la segunda palbra contadas
			List<int> contados = new List<int>();

			// Contador de lo cantidad de caracteres diferentes
			int contador = 0;

			if (palabra1.Length != palabra2.Length) {
				Console.WriteLine ("No son anagramas");
			} else {
				for (int i = 0; i < palabra1.Length; i++) {
					for (int c = 0; c < palabra2.Length; c++) {
						if (!contados.Contains(c) && palabra1 [i] == palabra2 [c]) {
							contados.Add (c);
							contador += 1;
							break;
						}
					}
				}
				if (contador == palabra1.Length) {
					Console.WriteLine ("Son anagramas");
				} else
					Console.WriteLine ("No son anagramas");
			}
		}
	}
}
