using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class ConjuredItemTest
	{
		[Test]
		public void DecreasesTwoQualityPointsPerDay ()
		{
			ComplexItem item = new ConjuredItem (10, 2);
			item.OnDayIncreased ();
			
			Assert.AreEqual (0, item.Quality);
		}

		[Test]
		public void DecreasesFourQualityPointsAfterExpires ()
		{
			ComplexItem item = new ConjuredItem (0, 6);
			item.OnDayIncreased ();
			
			Assert.AreEqual (2, item.Quality);
		}
	}
}
