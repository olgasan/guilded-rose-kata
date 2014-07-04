using UnityEngine;
using System.Collections;

public class SulfurasItem : ComplexItem
{
	protected override bool CanModifySellIn
	{
		get { return false; }
	}

	public SulfurasItem (int sellIn, int quality) : base (sellIn, quality)
	{
		base.Name = "Sulfuras, Hand of Ragnaros";
	}
}
