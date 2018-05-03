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
			string input;
			while ((input = Console.ReadLine()) != "End")
			{
				var tokens = input.Split();
				if (tokens.Length == 2)
				{
					Robot robot = ParseRobots(input);
					robots.Add(robot);
				}
				else
				{
					Citizen citizen = ParseCitizens(input);
					citizens.Add(citizen);
				}
			}

			var fakeId = Console.ReadLine();
			FakeIdPrinter(citizens, robots, fakeId);

		}
		public static void FakeIdPrinter(List<Citizen> citizens, List<Robot> robots, string fakeId)
		{
			foreach (var citizen in citizens)
			{
				if (citizen.Id.EndsWith(fakeId))
				{
					Console.WriteLine(citizen.Id);
				}
			}

			foreach (var robot in robots)
			{
				if (robot.Id.EndsWith(fakeId))
				{
					Console.WriteLine(robot.Id);
				}
			}
		}

		public static Robot ParseRobots(string input)
		{
			Robot robot;
			var tokens = input.Split();
			string model = tokens[0];
			string id = tokens[1];
			robot = new Robot(model, id);
			return robot;
		}

		public static Citizen ParseCitizens(string input)
		{
			Citizen citizen;
			var tokens = input.Split();
			string name = tokens[0];
			int age = int.Parse(tokens[1]);
			string id = tokens[2];
			citizen = new Citizen(name, age, id);
			return citizen;
		}
	}
}
