namespace Bakery.Models
{
	public abstract class BakeryItem
	{
		public abstract int BasePrice { get; }
		public abstract int FreeEvery { get; }
		public int Amount { get; set; }
	}
}