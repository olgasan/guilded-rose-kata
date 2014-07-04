using UnityEngine;
using System.Collections;

public abstract class ComplexItem : Item
{
	public ComplexItem (int sellIn, int quality)
	{
		base.SellIn = sellIn;
		base.Quality = quality;
	}

	public abstract void OnDayIncreased ();
}
