using UnityEngine;
using System.Collections;

public class SulfurasItem : ComplexItem
{
	public SulfurasItem (int sellIn, int quality) : base (sellIn, quality)
	{
		base.Name = "Sulfuras, Hand of Ragnaros";
	}

	public override void OnDayIncreased ()
	{

	}
}
