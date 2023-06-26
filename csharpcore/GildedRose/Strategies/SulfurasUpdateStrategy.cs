using GildedRoseKata;
using GildedRoseKata.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Strategies
{
	public class SulfurasUpdateStrategy : IUpdateStrategy
	{
		public Item UpdateItem(Item item)
		{
			item.SellIn--;
			return item;
		}
	}
}
