using UnityEngine;
using System.Collections;

public class RegularItem : ComplexItem
{
	protected override bool CanModifySellIn 
	{
		get { return true; }
	}
	
	public RegularItem(int sellIn, int quality) : base(sellIn, quality)
	{
	}
	
	public override void OnDayIncreased ()
	{
		base.OnDayIncreased();

		if (SellIn < 0)
			Quality = DecreaseItemQuality (2);
		
		else
			Quality = DecreaseItemQuality (1);
	}
}
