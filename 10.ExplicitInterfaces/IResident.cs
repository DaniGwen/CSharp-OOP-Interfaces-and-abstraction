using System;
using System.Collections.Generic;
using System.Text;

namespace _10.ExplicitInterfaces
{
   public interface IResident
    {
		string Name { get; }
		string Country { get; }

		 void GetName();
    }
}
