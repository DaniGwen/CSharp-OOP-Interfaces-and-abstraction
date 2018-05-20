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
			var season = Enum.Parse<SeasonsMultiplier>(tokens[2]);
			DiscountType discount = DiscountType.None;

			if (tokens.Length > 3)
			{
				discount = Enum.Parse<DiscountType>(tokens[3]);
			}
			discount = DiscountType.None;


			var calculator = new PriceCalculator(pricePerDay, numberOfdays, season, discount);
			Console.WriteLine(calculator.ToString());

		}
	}
}