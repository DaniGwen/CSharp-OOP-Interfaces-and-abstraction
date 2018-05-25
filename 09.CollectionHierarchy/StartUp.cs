using System;
using System.Collections.Generic;

namespace _09.CollectionHierarchy
{
    class StartUp
    {
        static void Main()
        {
			var addCollection = new AddCollection();
			var addRemoveCollection = new AddRemoveCollection();
			var myCollection = new MyCollection();

			var mergedCollection = new List<string>();

			var elementsToAdd = Console.ReadLine().Split();
			var amountOfRemove = int.Parse(Console.ReadLine());

			foreach (var item in elementsToAdd)
			{
				//addCollection.Add(item);
				//addRemoveCollection.Add(item);
				myCollection.Add(item);

			}
			Console.WriteLine(addCollection);
        }
    }
}
