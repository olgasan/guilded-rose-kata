using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class AgedBrieItemTest 
	{
		[Test]
		public void IncreasesOneQualityPointPerDay ()
		{
			ComplexItem item = new AgedBrieItem (2, 0);
			item.OnDayIncreased ();
			
			Assert.AreEqual (1, item.Quality);
		}

		[Test]
		public void IncreasesTwoQualityPointperDayAfterExpires ()
		{
			ComplexItem item = new AgedBrieItem (0, 0);
			item.OnDayIncreased ();
			
			Assert.AreEqual (2, item.Quality);
		}

		[Test]
		public void QualityDoesNotChangeWhenIsGreaterThan50 ()
		{
			ComplexItem item = new AgedBrieItem (1, 50);
			item.OnDayIncreased ();
			Assert.AreEqual (50, item.Quality);

			item.Quality = 77;
			item.OnDayIncreased ();
			Assert.AreEqual (77, item.Quality);
		}

		[Test]
		public void SetItsOwnName ()
		{
			ComplexItem item = new AgedBrieItem (0, 0);
			Assert.AreEqual ("Aged Brie", item.Name);
		}
	}
}
