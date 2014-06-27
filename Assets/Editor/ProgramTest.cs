using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	public class ProgramTest
	{
		private Program program;

		[Test]
		public void CanCreateAProgram ()
		{
			Item itemA = new Item ();
			Item itemB = new Item ();

			program = new Program (itemA, itemB);

			Assert.IsNotNull (program);
		}

		[Test]
		public void RegularItemDoesNotChangeWithNegativeQuality ()
		{
			Item item = CreateMockItem ("Elixir of the Mongoose", 1, -1);
			program = new Program (item);

			AssertItemValuesAfterOneDay (-1, 0, item);
		}

		[Test]
		public void RegularItemDecreasesOneQualityPointPerDay ()
		{
			Item item = CreateMockItem ("Elixir of the Mongoose", 5, 7);
			program = new Program (item);

			AssertItemValuesAfterOneDay (6, 4, item);
			AssertItemValuesAfterOneDay (5, 3, item);
		}

		[Test]
		public void RegularItemDecreasesTwoQualityPointperDayAfterExpires ()
		{
			Item item = CreateMockItem ("Elixir of the Mongoose", 0, 2);
			program = new Program (item);

			AssertItemValuesAfterOneDay (0, -1, item);
			AssertItemValuesAfterOneDay (0, -2, item);
		}

		[Test]
		public void AgedBrieIncreasesOneQualityPointPerDay ()
		{
			Item item = CreateMockItem ("Aged Brie", 2, 0);
			program = new Program (item);

			AssertItemValuesAfterOneDay (1, 1, item);
			AssertItemValuesAfterOneDay (2, 0, item);
		}

		[Test]
		public void AgedBrieIncreasesTwoQualityPointperDayAfterExpires ()
		{
			Item item = CreateMockItem ("Aged Brie", 0, 0);
			program = new Program (item);

			AssertItemValuesAfterOneDay (2, -1, item);
			AssertItemValuesAfterOneDay (4, -2, item);
		}

		[Test]
		public void QualityDoesNotChangeWhenIsGreaterThan50 ()
		{
			Item item = CreateMockItem ("Aged Brie", 1, 50);
			program = new Program (item);

			AssertItemValuesAfterOneDay (50, 0, item);

			item.Quality = 77;
			AssertItemValuesAfterOneDay (77, -1, item);
		}

		[Test]
		public void SulfurasDoesNotChangesItsQuality ()
		{
			Item item = CreateMockItem ("Sulfuras, Hand of Ragnaros", 0, 80);
			program = new Program (item);
			
			AssertItemValuesAfterOneDay (80, 0, item);
		}

		private void AssertItemValuesAfterOneDay (int expectedQuality, int expectedSellIn, Item item)
		{
			program.OnDayAdvanced (); //TODO: rename by OnDayAdvanced

			Assert.AreEqual (expectedQuality, item.Quality);
			Assert.AreEqual (expectedSellIn, item.SellIn);
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
