using GildedRoseKata;
using GildedRoseKata.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Strategies
{
	public class BrieUpdateStrategy : IUpdateStrategy
	{
		public Item UpdateItem(Item item)
		{
			if (item.Quality < 50)
			{
				item.Quality++;
			}

			item.SellIn--;

			if (item.Quality < 50 && item.SellIn < 0)
			{
				item.Quality++;
			}

			return item;
		}
	}
}
