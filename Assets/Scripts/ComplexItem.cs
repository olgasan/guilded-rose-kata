using UnityEngine;
using System.Collections;

public abstract class ComplexItem : Item
{
	protected abstract bool CanModifySellIn
	{
		get;
	}

	public ComplexItem (int sellIn, int quality)
	{
		base.SellIn = sellIn;
		base.Quality = quality;
	}

	public virtual void OnDayIncreased ()
	{
		if(CanModifySellIn)
			SellIn--;
	}

	protected int IncreaseItemQuality (int increaseQuantity)
	{
		int newQuality = Quality + increaseQuantity;
		int max = Quality < 50 ? 50 : Quality;
		return Mathf.Clamp (newQuality, 0, max);
	}

	protected int DecreaseItemQuality (int decreaseQuantity)
	{
		int newQuality = Quality - decreaseQuantity;
		int min = Quality < 0 ? Quality : 0;
		return Mathf.Clamp (newQuality, min, 50);
	}
}
