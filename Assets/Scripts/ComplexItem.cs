using UnityEngine;
using System.Collections;

public class ComplexItem 
{
	public int Quality
	{
		get { return item.Quality; }
	}

	public int SellIn
	{
		get{ return item.SellIn; }
	}

	private Item item;

	public ComplexItem (Item item)
	{
		this.item = item;
	}
}
