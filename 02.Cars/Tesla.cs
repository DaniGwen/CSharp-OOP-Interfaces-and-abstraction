using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Cars
{
	public class Tesla : IElectricCar, ICar
	{
		public int Battery { get; private set; }
		public string Model { get; private set; }
		public string Color { get; private set; }

		public Tesla(string model, string color, int batteries)
		{
			this.Model = model;
			this.Color = color;
			this.Battery = batteries;
		}

		public string Start()
		{
			return "Breaaak!";
		}

		public string Stop()
		{
			return "Stoping!";
		}

		public override string ToString()
		{
			return $"{Color} {typeof(Seat).Name} {Model} with {Battery} Batteries";	
		}
	}
}
