using System;

namespace EJ3
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

			int aux = 0;
			for (int i = int.Parse(numInf); i <= int.Parse(numSup); i++) {
				aux += i;
			}
			Console.WriteLine (aux/(int.Parse(numSup) - int.Parse(numInf) + 1));
		}
	}
}
