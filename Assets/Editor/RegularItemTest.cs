using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class RegularItemTest 
	{
		[Test]
		public void DecreasesOneQualityPointPerDay ()
		{
			ComplexItem item = new RegularItem (5, 7);
			item.OnDayIncreased();
			Assert.AreEqual(6, item.Quality);
		}

		[Test]
		public void DecreasesTwoQualityPointperDayAfterExpires ()
		{
			ComplexItem item = new RegularItem (0, 2);
			item.OnDayIncreased();
			Assert.AreEqual(0, item.Quality);
		}

		[Test]
		public void DoesNotChangeWithNegativeQuality ()
		{
			ComplexItem item = new RegularItem (1, -1);
			item.OnDayIncreased();
			Assert.AreEqual(-1, item.Quality);
		}
	}
}
