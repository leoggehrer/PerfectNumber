using System;

namespace Number.ConApp
{
	class Program
	{
#pragma warning disable IDE0060 // Remove unused parameter
		static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
		{
			Console.WriteLine("Number-App!");

			string input, output;
			long number;

			// Eingabe (E)
			do
			{
				Console.Write("Geben Sie eine Zahl ein: ");
				input = Console.ReadLine();

			} while (long.TryParse(input, out number) == false);

			// Verarbeitung (V)
			if (Number.Logic.NumberProperty.IsPerfect(number))
			{
				output = $"{number} ist eine perfekte Zahl:-)";
			}
			else
			{
				output = $"{number} ist KEINE perfekte Zahl";
			}

			// Ausgabe (A)
			Console.WriteLine(output);
		}
	}
}
