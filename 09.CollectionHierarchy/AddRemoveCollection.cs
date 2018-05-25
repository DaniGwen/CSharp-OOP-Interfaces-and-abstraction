using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.CollectionHierarchy
{
	public class AddRemoveCollection : AddCollection 
	{
		private List<string> addRemoveCollection;

		public AddRemoveCollection()
		{
			this.addRemoveCollection = new List<string>();
		}

		public new void Add(string element)
		{
			addRemoveCollection.Insert(0, element);
			int added = addRemoveCollection.IndexOf(element);
			Console.WriteLine(added);
		}

		public void Remove()
		{
			addRemoveCollection.RemoveAt(addRemoveCollection.Count - 1);
		}
	}
}
