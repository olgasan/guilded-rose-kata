using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class SulfurasItemTest 
	{
		[Test]
		public void DoesNotChangeItsQuality ()
		{
			ComplexItem item = new SulfurasItem (2, 100);
			item.OnDayIncreased ();
			
			Assert.AreEqual (item.Quality, 100);
		}

		[Test]
		public void DoesNotChangeItsSellIn ()
		{
			ComplexItem item = new SulfurasItem (2, 100);
			item.OnDayIncreased ();
			
			Assert.AreEqual (item.SellIn, 2);
		}

		[Test]
		public void SetItsOwnName ()
		{
			ComplexItem item = new SulfurasItem (0, 0);
			Assert.AreEqual ("Sulfuras, Hand of Ragnaros", item.Name);
		}
	}
}
