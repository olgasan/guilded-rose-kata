using UnityEngine;
using System.Collections;

public class ComplexItem 
{
	public int Quality
	{
		get;
		private set;
	}

	public int SellIn
	{
		get;
		private set;
	}

	public ComplexItem (Item item)
	{
		Quality = item.Quality;
		SellIn = item.SellIn;
	}
}
