using GildedRoseKata;
using GildedRoseKata.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Strategies
{
	public class BackstageUpdateStrategy : IUpdateStrategy
	{
		public Item UpdateItem(Item item)
		{
			if (item.SellIn <= 0)
			{
				// Ticket will void, no need for the rest of the logic
				item.SellIn--;
				item.Quality = 0;
				return item;
			}

			if (item.Quality < 50)
			{
				item.Quality++;
			}

			if (item.SellIn < 11 && item.Quality < 50)
			{
				item.Quality++;
			}

			if (item.SellIn < 6 && item.Quality < 50)
			{
				item.Quality++;
			}

			item.SellIn--;

			return item;
		}
	}
}
