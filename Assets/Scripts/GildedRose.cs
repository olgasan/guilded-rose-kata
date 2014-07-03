using System.Collections.Generic;
using UnityEngine;

public class Program
{
	IList<Item> items;

	public Program (params Item[] items)
	{
		this.items = new List<Item> ();

		foreach (Item item in items)
		{
			this.items.Add (item);
		}
	}

	static void Main(string[] args)
	{
		var app = new Program()
		{
			items = new List<Item>
			{
				new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
				new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
				new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
				new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 15,
					Quality = 20
				},
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
			}
			
		};
		
		app.OnDayAdvanced();
		
	}
	
	public void OnDayAdvanced()
	{
		for (var i = 0; i < items.Count; i++)
		{
			Item item = items[i];

			if (item.Name != "Sulfuras, Hand of Ragnaros")
			{
				item.SellIn = item.SellIn - 1;
				
				if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
				{
					if (items[i].SellIn < 0)
					{
						items[i].Quality = 0;
					}
					else 
					{
						if (item.SellIn < 11 && item.SellIn >= 6)
							item.Quality = IncreaseItemQuality (item, 2);
						
						else if (item.SellIn < 6)
							item.Quality = IncreaseItemQuality (item, 3);
						
						else
							item.Quality = IncreaseItemQuality (item, 1);
					}
				}
				else if (item.Name == "Aged Brie")
				{
					if (item.SellIn < 0)
						item.Quality = IncreaseItemQuality (item, 2);

					else
						item.Quality = IncreaseItemQuality (item, 1);
				}
				else
				{
					if (item.SellIn < 0)
						item.Quality = DecreaseItemQuality (item, 2);

					else
						item.Quality = DecreaseItemQuality (item, 1);
				}
			}

		}
	}

	private int IncreaseItemQuality (Item item, int increaseQuantity)
	{
		int newQuality = item.Quality + increaseQuantity;
		int max = item.Quality < 50 ? 50 : item.Quality;
		return Mathf.Clamp (newQuality, 0, max);
	}

	private int DecreaseItemQuality (Item item, int decreaseQuantity)
	{
		int newQuality = item.Quality - decreaseQuantity;
		int min = item.Quality < 0 ? item.Quality : 0;
		return Mathf.Clamp (newQuality, min, 50);
	}
}
