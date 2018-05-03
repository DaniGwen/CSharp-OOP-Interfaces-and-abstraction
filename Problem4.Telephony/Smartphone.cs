using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem4.Telephony
{
	class Smartphone : IBrowser, ICall
	{

		public List<string> Numbers { get; private set; }

		public List<string> Sites { get; private set; }


		public void Browse(List<string> sites)
		{
			var regex = "^([A-Za-z://.])*$";
			
			foreach (var site in sites)
			{
				var match = Regex.IsMatch(site, regex);
				if (match)
				{
					Console.WriteLine($"Browsing: { site }!");
				}
				else
				{
					Console.WriteLine("Invalid URL!");
				}
			}
		}

		public void Calling(List<string> numbers)
		{
			string pattern = @"^[0-9]*$";
			foreach (var number in numbers)
			{
				var match = Regex.IsMatch(number, pattern);
				if (match)
				{
					Console.WriteLine($"Calling... {number}");
				}
				else
				{
					Console.WriteLine("Invalid number!");
				}
			}
		}
		
	}
}
