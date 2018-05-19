using System;

namespace _03.StudentSystem
{
    class StartUp
    {
        static void Main()
        {
			string input = Console.ReadLine();

			CommandInterpriter.Run(input);
        }
    }
}
