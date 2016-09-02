using System;

namespace EJ8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Asigno los primeros 2 numeros de la serie
			
			long aux = 1;
			long aux2 = 1;
			Console.WriteLine (aux);

			for (int i = 0; i < 50; i++) {
				Console.WriteLine (aux2);
				long aux3 = aux;
				aux = aux2;
				aux2 = aux3 + aux;
			}
		}
	}
}
