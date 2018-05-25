using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Cars
{
    public class Seat: ICar
    {
		public string Model { get; private set; }

		public string Color { get; private set; }

		private string state { get; set; }

		public Seat(string model, string color)
		{
			this.Model = model;
			this.Color = color;
		}

		public string Start()
		{
			return "Breaak!";
		}

		public string Stop()
		{
			return "Stopping";
		}

		public override string ToString()
		{
			return $"{this.Color} {typeof(Seat).Name} {this.Model}!";
		}
	}
}
