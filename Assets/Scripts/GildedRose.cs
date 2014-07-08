using System.Collections.Generic;
using UnityEngine;

public class Program
{
	IList<Item> items;

	public Program (params Item[] items)
	{
		this.items = new List<Item> ();

		foreach (Item item in items)
		{
			this.items.Add (item);
		}
	}

	public void OnDayAdvanced()
	{
		for (var i = 0; i < items.Count; i++)
		{
			Item item = items[i];

			ComplexItem cItem = item as ComplexItem;
			cItem.OnDayIncreased ();
		}
	}
}
