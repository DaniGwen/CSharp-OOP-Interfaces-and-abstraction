using System;

namespace _04.HotelReservation
{
    class StartUp
    {
        static void Main()
        {
			string input = Console.ReadLine();

			ReadInput(input);
		}

		private static void ReadInput(string input)
		{
			var tokens = input.Split();
			var pricePerDay = decimal.Parse(tokens[0]);
			var numberOfdays = int.Parse(tokens[1]);
			var season = tokens[2];
			var discount = tokens[3];

			PriceCalculator calculator = new PriceCalculator(pricePerDay, numberOfdays, season, discount);
			Console.WriteLine(calculator.ToString());

		}
	}
}
