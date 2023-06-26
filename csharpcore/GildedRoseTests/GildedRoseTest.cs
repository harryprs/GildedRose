using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;
using System;
using GildedRoseTests.Comparers;

namespace GildedRoseTests
{
	public class GildedRoseTest
	{
		[Fact]
		public void foo()
		{
			IList<Item> ExpectedItems = new List<Item>{
				new Item {Name = "+5 Dexterity Vest", SellIn = 9, Quality = 19},
				new Item {Name = "Aged Brie", SellIn = 1, Quality = 1},
				new Item {Name = "Aged Brie", SellIn = -1, Quality = 2},
				new Item {Name = "Elixir of the Mongoose", SellIn = 4, Quality = 6},
				new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
				new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
				new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -2, Quality = 80},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 14,
					Quality = 21
				},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 9,
					Quality = 50
				},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 4,
					Quality = 50
				},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 4,
					Quality = 49
				},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = -1,
					Quality = 0
				},
                // this conjured item does not work properly yet
                new Item {Name = "Conjured Mana Cake", SellIn = 2, Quality = 4},
				new Item {Name = "Conjured Mana Cake", SellIn = 2, Quality = 0},
				new Item {Name = "Conjured Mana Cake", SellIn = -1, Quality = 2},
				new Item {Name = "Conjured Mana Cake", SellIn = -1, Quality = 0},
				new Item {Name = "Conjured Mana Cake", SellIn = -1, Quality = 0}
			};

			IList<Item> Items = new List<Item>{
				new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
				new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
				new Item {Name = "Aged Brie", SellIn = 0, Quality = 0},
				new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
				new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 80},
				new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
				new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 15,
					Quality = 20
				},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 10,
					Quality = 49
				},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 5,
					Quality = 49
				},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 5,
					Quality = 46
				},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 0,
					Quality = 49
				},
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6},
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 1},
				new Item {Name = "Conjured Mana Cake", SellIn = 0, Quality = 6},
				new Item {Name = "Conjured Mana Cake", SellIn = 0, Quality = 3},
				new Item {Name = "Conjured Mana Cake", SellIn = 0, Quality = 1}
			};

			GildedRoseMain app = new GildedRoseMain(Items);
			app.UpdateQuality();

			CollectionAssert.AreEqual(ExpectedItems, Items, new QualityComparer());
			CollectionAssert.AreEqual(ExpectedItems, Items, new SellInComparer());
		}
	}
}
