using System;

namespace EJ1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Ingrese un numero: ");
			string num = Console.ReadLine ();

			if (num == "1") {
				Console.WriteLine("UNO");
			} else if (num == "2") {
				Console.WriteLine("DOS");
			} else if (num == "3") {
				Console.WriteLine("TRES");
			} else if (num == "4") {
				Console.WriteLine("CUATRO");
			} else if (num == "5") {
				Console.WriteLine("CINCO");
			} else if (num == "6") {
				Console.WriteLine("SEIS");
			} else if (num == "7") {
				Console.WriteLine("SIETE");
			} else if (num == "8") {
				Console.WriteLine("OCHO");
			} else if (num == "9") {
				Console.WriteLine("NUEVE");
			} else {
				Console.WriteLine("OTROS");
			}
		}
	}
}
