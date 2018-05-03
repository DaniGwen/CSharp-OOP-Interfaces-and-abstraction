using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7.FoodShortage
{
	class StartUp
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			var rebels = new Dictionary<string, Rebel>();
			var citizens = new Dictionary<string, Citizen>();

			while (n > 0)
			{
				string[] input = Console.ReadLine().Split();

				if (input.Length == 4)
				{
					var citizen = ParseCitizen(input);
					if (!citizens.ContainsKey(citizen.Name))
					{
						citizens.Add(citizen.Name, citizen);
					}
				}
				else
				{
					var rebel = ParseRebel(input);
					if (!rebels.ContainsKey(rebel.Name))
					{
						rebels.Add(rebel.Name, rebel);
					}	
				}
				n--;
			}

			string buyingFood;

			while ((buyingFood = Console.ReadLine()) != "End")
			{
				if (citizens.ContainsKey(buyingFood))
				{
					citizens[buyingFood].BuyFood();
				}
				else if (rebels.ContainsKey(buyingFood))
				{
					rebels[buyingFood].BuyFood();
				}
			}
			Console.WriteLine(citizens.Sum(c => c.Value.Food) + rebels.Sum(r => r.Value.Food));
		}

		public static Rebel ParseRebel(string[] input)
		{
			string name = input[0];
			string age = input[1];
			string group = input[2];
			Rebel rebel = new Rebel(name, age, group);

			return rebel;
		}

		public static Citizen ParseCitizen(string[] input)
		{
			
			string name = input[0];
			int age = int.Parse(input[1]);
			string id = input[2];
			string birthday = input[3];
			Citizen citizen = new Citizen(name, age, id, birthday);

			return citizen;
		}
	}
}

