﻿using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class ComplexItemTest
	{
		internal class ComplexItemMock : ComplexItem 
		{
			public ComplexItemMock (int sellIn, int quality) : base (sellIn, quality)
			{

			}

			protected override bool CanModifySellIn 
			{
				get { return true; }
			}
		}

		[Test]
		public void SellInDecreasesByOneADayPasses ()
		{
			ComplexItem item = new ComplexItemMock (10, 0);
			int prevSellIn = item.SellIn;

			item.OnDayIncreased ();
			Assert.That (item.SellIn, Is.LessThan (prevSellIn));
		}
	}
}