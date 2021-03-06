﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Problem7.FoodShortage
{
	public class Citizen : IBuyer
	{
		public string Name { get; private set; }
		public int Age { get; private set; }
		public string Id { get; private set; }
		public string Birthday { get; private set; }
		public int Food { get; private set; }

		public Citizen(string name, int age, string id, string birthday)
		{
			this.Name = name;
			this.Age = age;
			this.Id = id;
			this.Birthday = birthday;
			Food = 0;
		}

		public void BuyFood()
		{
			Food += 10;
		}
	}
}
