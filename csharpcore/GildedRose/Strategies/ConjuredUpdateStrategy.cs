using GildedRoseKata;
using GildedRoseKata.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Strategies
{
	public class ConjuredUpdateStrategy : IUpdateStrategy
	{
		public Item UpdateItem(Item item)
		{
			if (item.Quality > 0)
			{
				item.Quality -= 2;
			}

			item.SellIn--;

			if (item.Quality > 0 && item.SellIn < 0)
			{
				item.Quality -= 2;
			}

			item.Quality = item.Quality < 0 ? 0 : item.Quality;

			return item;
		}
	}
}
