using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
	public class Ferrari : ICar
	{
		public string Model { get; private set; }
		public string Driver { get; private set; }

		public string Brakes()
		{
			return "Brakes!";
		}

		public string Gas()
		{
			return "Zadu6avam sA!";
		}

		public Ferrari(string driver)
		{
			Model = "488-Spider";
			this.Driver = driver;
		}

		public override string ToString()
		{
			return $"{Model}/{Brakes()}/{Gas()}/{this.Driver}";
		}

		
	}
}
