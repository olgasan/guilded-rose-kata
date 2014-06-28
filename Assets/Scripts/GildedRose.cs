﻿using System.Collections.Generic;
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
			if (items[i].Name != "Aged Brie" && items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
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
					
					if (items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
					{
						if (items[i].SellIn < 11)
						{
							if (items[i].Quality < 50)
							{
								items[i].Quality = items[i].Quality + 1;
							}
						}
						
						if (items[i].SellIn < 6)
						{
							if (items[i].Quality < 50)
							{
								items[i].Quality = items[i].Quality + 1;
							}
						}
					}
				}
			}
			
			if (items[i].Name != "Sulfuras, Hand of Ragnaros")
			{
				items[i].SellIn = items[i].SellIn - 1;
			}
			
			if (items[i].SellIn < 0)
			{
				if (items[i].Name != "Aged Brie")
				{
					if (items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
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
						items[i].Quality = items[i].Quality - items[i].Quality;
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
