using System;

namespace EJ9
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int aux = 0;
			for (int i = 35; i < 1978; i++) {
				if (esNumeroPrimo (i)) {
					aux += i;
				}
			}
			Console.WriteLine (aux);
		}

		// Funcion que calcula si el numero es primo

		public static bool esNumeroPrimo(int numero)
		{
			for (int i = 2; i < numero; i++) {
				if (numero % i == 0) {
					return false;
				}
			}
			return true;
		}
	}
}
