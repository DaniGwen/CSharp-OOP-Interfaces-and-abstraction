using System;

namespace Ferrari
{
    class stratUp
    {
        static void Main()
        {
			string driver = Console.ReadLine();

			ICar car = new Ferrari(driver);

			Console.WriteLine(car);
        }
    }
}
