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
		public void RegularItemDecreasesOnePerDay ()
		{
			Item item = CreateMockItem ("Elixir of the Mongoose", 5, 7);

			Program program = new Program (item);
			program.UpdateQuality ();

			Assert.AreEqual (6, item.Quality);
			Assert.AreEqual (4, item.SellIn);
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
