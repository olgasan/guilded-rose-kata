using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	public class ComplexItemTest
	{
		[Test]
		public void RequiresAnItem()
		{
			Item item = new Item();
			ComplexItem complexitem = new ComplexItem(item);
			Assert.IsNotNull(complexitem);
		}

		[Test]
		public void ComplexItemUsesParentItemInfo()
		{
			Item item = new Item();
			item.Quality = 50;
			item.SellIn = 100;
			ComplexItem complexitem = new ComplexItem(item);
			Assert.AreEqual(item.Quality, complexitem.Quality);
			Assert.AreEqual(item.SellIn, complexitem.SellIn);

			item.Quality = 0;
			item.SellIn = 0;
			Assert.AreEqual(item.Quality, complexitem.Quality);
			Assert.AreEqual(item.SellIn, complexitem.SellIn);

		}
	}
}
