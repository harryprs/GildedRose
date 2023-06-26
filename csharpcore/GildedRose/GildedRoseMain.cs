using GildedRoseKata.Factory;
using GildedRoseKata.Strategies;
using System.Collections.Generic;

namespace GildedRoseKata
{
	public class GildedRoseMain
	{
		IList<Item> Items;
		public GildedRoseMain(IList<Item> Items)
		{
			this.Items = Items;
		}

		public void UpdateQuality()
		{
			StrategyFactory stratFactory = new StrategyFactory();
			for (var i = 0; i < Items.Count; i++)
			{
				IUpdateStrategy strategy = stratFactory.CreateStrategy(Items[i].Name);
				strategy.UpdateItem(Items[i]);
			}
		}
	}
}
