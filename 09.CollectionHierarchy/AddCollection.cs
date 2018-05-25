using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CollectionHierarchy
{
  public class AddCollection: ICollection
    {
		private List<string> addCollection;

		public AddCollection()
		{
			this.addCollection = new List<string>();
		}

		public new void  Add(string element)
		{
			addCollection.Add(element);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			for (int i = 0; i < addCollection .Count; i++)
			{
				sb.Append($"{i} ");
			}

			var result = sb.ToString().TrimEnd();
			return result;
		}
	}
}
