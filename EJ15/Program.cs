using System;

namespace EJ15
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			const int menor = 15;
			const int mayor = 150;
			int[] arreglo = new int[50];
			Random rnd = new Random();

			// Relleno el arreglo con enteros aleatorios entre menor y mayor

			for (int i = 0; i < arreglo.Length; i++) {
				arreglo [i] = rnd.Next(menor, mayor);
			}

			// Ordenamiento burbuja

			for (int i = 1; i <  arreglo.Length; i++) {
				for (int c = 0; c < arreglo.Length -1; c++) {
					if (arreglo[c] > arreglo[c + 1]) {
						int aux = arreglo [c];
						arreglo [c] = arreglo [c + 1];
						arreglo [c + 1] = aux;
					}
				}
			}

			// Muestro el arreglo ordenado

			for (int i = 0; i < arreglo.Length; i++) {
				Console.WriteLine (arreglo [i]);
			}
		}
	}
}
