using System;
using System.Linq;

namespace Problem4.Telephony
{
    class StartUp
    {
        static void Main()
        {
			var phoneNumbers = Console.ReadLine()
				.Split()
				.ToList();

			var sites = Console.ReadLine()
				.Split()
				.ToList();

			Smartphone device = new Smartphone();
			device.Calling(phoneNumbers);
			device.Browse(sites);
        }
    }
}
