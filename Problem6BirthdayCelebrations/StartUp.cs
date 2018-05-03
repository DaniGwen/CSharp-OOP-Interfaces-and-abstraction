using System;
using System.Collections.Generic;

namespace Problem5.BorderControl
{
	class StartUp
	{
		static void Main(string[] args)
		{
			List<Robot> robots = new List<Robot>();
			List<Citizen> citizens = new List<Citizen>();
			List<Pet> pets = new List<Pet>();

			string input;
			while ((input = Console.ReadLine()) != "End")
			{
				var tokens = input.Split();
				switch (tokens[0])
				{
					case "Citizen":
						Citizen citizen = ParseCitizens(input);
						citizens.Add(citizen);
						break;
					case "Pet":
						Pet pet = ParsePet(input);
						pets.Add(pet);
						break;
					case "Robot":
						Robot robot = ParseRobots(input);
						robots.Add(robot);
						break;
					default:
						break;
				}
			}
			var birthday = Console.ReadLine();
			List<string> birthDates = Birthdays(citizens, pets, birthday);
				foreach (var birthdays in birthDates)
				{
					Console.WriteLine(birthdays);
				}
		}
		public static List<string> Birthdays(List<Citizen> citizens,List<Pet> pets, string birthDate)
		{

			List<string> birthday = new List<string>();
			foreach (var citizen in citizens)
			{
				if (citizen.Birthday.EndsWith(birthDate))
				{
					birthday.Add(citizen.Birthday);
				}
			}

			foreach (var pet in pets)
			{
				if (pet.Birthday.EndsWith(birthDate))
				{
					birthday.Add(pet.Birthday);
				}
			}
			return birthday;
		}

		public static Robot ParseRobots(string input)
		{
			Robot robot;
			var tokens = input.Split();
			string model = tokens[1];
			string id = tokens[2];
			robot = new Robot(model, id);
			return robot;
		}

		public static Citizen ParseCitizens(string input)
		{
			Citizen citizen;
			var tokens = input.Split();
			string name = tokens[1];
			int age = int.Parse(tokens[2]);
			string id = tokens[3];
			string birthday = tokens[4];
			citizen = new Citizen(name, age, id, birthday);
			return citizen;
		}

		public static Pet ParsePet(string input)
		{
			Pet pet ;
			var tokens = input.Split();
			string name = tokens[1];
			string birthday = tokens[2];
			pet = new Pet(name, birthday);
			return pet;
		}
	}
}
