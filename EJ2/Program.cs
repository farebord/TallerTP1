using System;

namespace EJ2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Ingrese un numero: ");
			string num = Console.ReadLine ();

			switch (num) {

				case "1":
					Console.WriteLine ("UNO");
					break;

				case "2":
					Console.WriteLine ("DOS");
					break;

				case "3":
					Console.WriteLine ("TRES");
					break;

				case "4":
					Console.WriteLine ("CUATRO");
					break;

				case "5":
					Console.WriteLine ("CINCP");
					break;
				
				case "6":
					Console.WriteLine ("SEIS");
					break;
				
				case "7":
					Console.WriteLine ("SIETE");
					break;

				case "8":
					Console.WriteLine ("OCHO");
					break;

				case "9":
					Console.WriteLine ("NUEVE");
					break;

				default:
					Console.WriteLine ("OTROS");
					break;
			}
		}
	}
}
