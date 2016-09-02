using System;

namespace EJ12
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Ingrese un numero: ");
			long numero = Convert.ToInt64 (Console.ReadLine ());
			Console.WriteLine ("El factorial del numero ingresado es: " + factorial (numero));
		}

		// Creo una funcion que realice el factorial

		public static long factorial(long numero)
		{
			long aux = numero;
			for (long i = numero - 1; i > 0; i--) {
				aux = aux * i;
			}
			return aux;
		}
	}
}
