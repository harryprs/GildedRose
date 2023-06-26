using GildedRoseKata.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Factory
{
	public class StrategyFactory
	{
		public StrategyFactory() { }

		public IUpdateStrategy CreateStrategy(string name)
		{
			switch (name)
			{
				case "Aged Brie":
					return new BrieUpdateStrategy();
				case "Backstage passes to a TAFKAL80ETC concert":
					return new BackstageUpdateStrategy();
				case "Sulfuras, Hand of Ragnaros":
					return new SulfurasUpdateStrategy();
				case "Conjured Mana Cake":
					return new ConjuredUpdateStrategy();
				default:
					return new NormalUpdateStrategy();
			}
		}
	}
}
