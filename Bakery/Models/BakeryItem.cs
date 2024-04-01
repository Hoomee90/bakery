using System;

namespace Bakery.Models
{
	public abstract class BakeryItem
	{
		public abstract int BasePrice { get; }
		public abstract int FreeEvery { get; }
		public int Amount { get; set; }
		
		public int FindTotalCost()
		{
			return (int)(BasePrice * (Amount - Math.Floor((decimal)(Amount / FreeEvery))));
		}
	}
}