using System;

namespace EJ14
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			double[] arreglo = new double[30];
			double menor = 0.0;
			double mayor = 0.0;
			double suma = 0.0;
			Random rnd = new Random ();

			// Relleno el arreglo de numeros tipo double

			for (int i = 0; i < 30; i++) {
				arreglo [i] = rnd.NextDouble();

				// Si es la primera vuelta, se asigna el primero como menor y mayor

				if (i == 0) {
					menor = arreglo [i];
					mayor = arreglo [i];
				}

				// Comparamos el actual menor y mayor con el numero actual y lo cambiamso si hace falta.

				if (arreglo [i] > mayor)
					mayor = arreglo [i];
				if (arreglo [i] < menor)
					menor = arreglo [i];
				suma += arreglo [i];
			}
			Console.WriteLine ("El menor es: " + menor);
			Console.WriteLine ("El mayor es: " + mayor);
			Console.WriteLine ("La suma es: " + suma);
			Console.WriteLine ("El promedio es: " + suma/arreglo.Length);

		}
	}
}
