using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	public class ProgramTest
	{
		[Test]
		public void CanCreateAProgram ()
		{
			Item itemA = new Item ();
			Item itemB = new Item ();

			Program program = new Program (itemA, itemB);

			Assert.IsNotNull (program);
		}

		[Test]
		public void RegularItemDecreasesOneQualityPointPerDay ()
		{
			Item item = CreateMockItem ("Elixir of the Mongoose", 5, 7);

			Program program = new Program (item);
			program.UpdateQuality ();

			Assert.AreEqual (6, item.Quality, "First day");
			Assert.AreEqual (4, item.SellIn, "First day");

			program.UpdateQuality ();

			Assert.AreEqual (5, item.Quality, "Second day");
			Assert.AreEqual (3, item.SellIn, "Second day");
		}

		[Test]
		public void RegularItemDecreasesTwoQualityPointperDayAfterExpires ()
		{
			Item item = CreateMockItem ("Elixir of the Mongoose", 0, 7);
			
			Program program = new Program (item);
			program.UpdateQuality ();
			
			Assert.AreEqual (5, item.Quality, "last day");
			Assert.AreEqual (-1, item.SellIn, "last day");
		}

		private Item CreateMockItem (string name, int sellIn, int quality)
		{
			Item item = new Item ();
			item.Name = name;
			item.SellIn = sellIn;
			item.Quality = quality;

			return item;
		}
	}
}
