using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.BorderControl
{
    public class Pet
    {
		public string Name { get; private set; }
		public string Birthday { get; private set; }

		public Pet(string name, string birthday)
		{
			this.Name = name;
			this.Birthday = birthday;
		}
    }
}
