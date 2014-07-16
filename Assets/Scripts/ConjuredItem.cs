using UnityEngine;

public class ConjuredItem : RegularItem 
{
	protected override int QualityMultiplier 
	{
		get { return 2; }
	}

	public ConjuredItem (int sellIn, int quality) : base(sellIn, quality)
	{
	}
}
