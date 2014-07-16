using UnityEngine;
using System.Collections;

public class RegularItem : ComplexItem
{
	protected virtual int QualityMultiplier
	{
		get { return 1; }
	}

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
			Quality = DecreaseItemQuality (2 * QualityMultiplier);
		
		else
			Quality = DecreaseItemQuality (1 * QualityMultiplier);
	}
}
