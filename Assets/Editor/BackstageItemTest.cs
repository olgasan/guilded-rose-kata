using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class BackstageItemTest 
	{
		[Test]
		public void QualityIncreasesByOneWhenSellInIsGreaterThan10 ()
		{
			ComplexItem item = new  BackstageItem(15, 20);
			item.OnDayIncreased();
			Assert.AreEqual(21, item.Quality);
		}

		[Test]
		public void QualityIncreasesByTwoWhenSellInIsBetween5And10 ()
		{
			ComplexItem item = new  BackstageItem(10, 20);
			item.OnDayIncreased();
			Assert.AreEqual(22, item.Quality);
		}

		[Test]
		public void QualityIncreasesByTwoWhenSellInIsLessThan5 ()
		{
			ComplexItem item = new  BackstageItem(5, 20);
			item.OnDayIncreased();
			Assert.AreEqual(23, item.Quality);
		}

		[Test]
		public void QualityIsZeroWhenExpires ()
		{
			ComplexItem item = new  BackstageItem(0, 20);
			Assert.AreEqual(20, item.Quality);
			item.OnDayIncreased();
			Assert.AreEqual (0, item.Quality);
		}

		[Test]
		public void QualityCannotBeGreaterThan50 ()
		{
			ComplexItem item = new  BackstageItem(3, 49);
			item.OnDayIncreased();
			Assert.AreEqual(50, item.Quality);
		}
	}
}
