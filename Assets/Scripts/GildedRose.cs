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

			UpdateSellIn (item);

			if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
			{

				if (items[i].SellIn < 0)
				{
					items[i].Quality = 0;
				}
				else if (item.Quality < 50)
				{

					if (item.SellIn < 11 && item.SellIn >= 6)
					{
						item.Quality = items[i].Quality + 2;
					}
					else if (item.SellIn < 6)
					{
						item.Quality = item.Quality + 3;
					}
					else
						item.Quality = item.Quality + 1;
				}
			}
			else
			{
				if (items[i].Name != "Aged Brie")
				{
					if (items[i].Quality > 0)
					{
						if (items[i].Name != "Sulfuras, Hand of Ragnaros")
						{
							items[i].Quality = items[i].Quality - 1;
						}
					}
				}
				else
				{
					if (items[i].Quality < 50)
					{
						items[i].Quality = items[i].Quality + 1;
						
						
					}
				}
				
				if (items[i].SellIn < 0)
				{
					if (items[i].Name != "Aged Brie")
					{
						if (items[i].Quality > 0)
						{
							if (items[i].Name != "Sulfuras, Hand of Ragnaros")
							{
								items[i].Quality = items[i].Quality - 1;
							}
						}
					}
					else
					{
						if (items[i].Quality < 50)
						{
							items[i].Quality = items[i].Quality + 1;
						}
					}
				}
			}
		}
	}
	
	private void UpdateSellIn (Item item)
	{
		if (item.Name != "Sulfuras, Hand of Ragnaros") {
			item.SellIn = item.SellIn - 1;
		}
	}
}
