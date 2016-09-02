using System;

namespace EJ11
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Ingrese radio: ");
			float numero = Convert.ToSingle (Console.ReadLine ());
			Console.WriteLine ("El area es: " + Math.PI * Math.Pow (numero, 2));
			Console.WriteLine ("El perimetro de su circunferencia: " + 2 * Math.PI * numero);
		}
	}
}
