using System;

namespace EJ5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Ingrese limite inferior: ");
			string numInf = Console.ReadLine();

			Console.Write ("Ingrese limite superior: ");
			string numSup = Console.ReadLine();

			if (int.Parse (numSup) <= int.Parse (numInf)) {
				Console.WriteLine ("El limite superior debe ser mayor al limite inferior");
				return;
			}

			int contador = int.Parse (numInf);
			int aux = 0;
			do {
				aux += contador;
				contador += 1;
			} while (contador <= int.Parse (numSup));

			Console.WriteLine (aux/(int.Parse(numSup) - int.Parse(numInf) + 1));
		}
	}
}
