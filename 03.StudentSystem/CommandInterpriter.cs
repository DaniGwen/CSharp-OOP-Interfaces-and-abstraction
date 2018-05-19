using System;
using System.Collections.Generic;
using System.Text;

namespace _03.StudentSystem
{
   public static class CommandInterpriter
    {
		public static void Run(string input)
		{
			while (input != "Exit")
			{
				var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				var command = tokens[0];

				switch (command)
				{
					case "Create":
						var name = tokens[1];
						var age = int.Parse(tokens[2]);
						var grade = double.Parse(tokens[3]);
						StudentFactory.Create(name, age, grade);
						break;

					case "Show":
						 name = tokens[1];
						Repository.Show(name);
						break;

					default:
						throw new InvalidOperationException("Invalid command!");
				}

				input = Console.ReadLine();
			}
		}
    }
}
