using UnityEngine;
using System.Collections;

public class AgedBrieItem : ComplexItem
{
	protected override bool CanModifySellIn 
	{
		get { return true; }
	}
	
	public AgedBrieItem(int sellIn, int quality) : base(sellIn, quality)
	{
		Name = "Aged Brie";
	}
	
	public override void OnDayIncreased ()
	{
		base.OnDayIncreased();

		if (SellIn < 0)
			Quality = IncreaseItemQuality (2);
		
		else
			Quality = IncreaseItemQuality (1);
	}
}
