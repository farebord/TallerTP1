using System;
using System.Collections.Generic;
using System.Text;

namespace EJ13
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length == 0) {
				Console.WriteLine ("Debe ingresar al menos una cadena de texto");
				return;
			}

			// Realiza un for desde el ultimo hasta el primer caracter.

			for (int i = args.Length; i > 0; i--) {
				string cadena = "";
				for (int c = args[i - 1].Length; c > 0; c--) {
					cadena += args [i - 1] [c - 1];
				}
				Console.WriteLine (cadena);
			}
		}
	}
}
