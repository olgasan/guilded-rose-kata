using UnityEngine;
using System.Collections;

public class BackstageItem : ComplexItem
{
	protected override bool CanModifySellIn 
	{
		get { return true; }
	}

	public BackstageItem(int sellIn, int quality) : base(sellIn, quality)
	{
		base.Name = "Backstage passes to a TAFKAL80ETC concert";
	}

	public override void OnDayIncreased ()
	{
		base.OnDayIncreased();

		if (SellIn < 0)
			Quality = 0;
		else 
		{
			if (SellIn < 11 && SellIn >= 6)
				Quality = IncreaseItemQuality (2);
			
			else if (SellIn < 6)
				Quality = IncreaseItemQuality (3);
			
			else
				Quality = IncreaseItemQuality (1);
		}
	}
}
