using System;
using System.Collections.Generic;
using System.Text;

namespace Problem7.FoodShortage
{
	class Rebel : IBuyer
	{
		public string Name { get; private set; }
		public string Age { get; private set; }
		public string Group { get; private set; }
		public int Food { get; private set; }

		public Rebel(string name, string age, string group)
		{
			this.Name = name;
			this.Age = age;
			this.Group = group;
			Food = 0;
		}

		public void BuyFood()
		{
			Food += 5;
		}
	}
}
