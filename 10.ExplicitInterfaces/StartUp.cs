using System;

namespace _10.ExplicitInterfaces
{
    class StartUp
    {
        static void Main()
        {
			string input = "";
			while ((input = Console.ReadLine()) != "End")
			{
				var tokens = input.Split();
				var name = tokens[0];
				var country = tokens[1];
				var age = int.Parse(tokens[2]);
				IResident citizen = new Citizen(name,country,age);
				IPerson person = new Citizen(name, country, age);
				citizen.GetName();
				person.GetName();
			}
        }
    }
}
