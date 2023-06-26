using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTests.Comparers
{
	public class QualityComparer : Comparer<Item>
	{
		public override int Compare(Item x, Item y)
		{
			return x.Quality.CompareTo(y.Quality);
		}
	}
}
