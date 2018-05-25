using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.CollectionHierarchy
{
    public class MyCollection:AddRemoveCollection 
    {
		private List<string> myCollection;

		private int used;

		public int Used
		{
			get { return used; }
			set { used = myCollection.Count; }
		}


		public MyCollection()
		{
			this.myCollection = new List<string>();
		}

		public new string Remove()
		{
			string removed = myCollection.FirstOrDefault().ToString();
			myCollection.RemoveAt(0);

			return removed;
		}
    }
}
