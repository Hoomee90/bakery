namespace Bakery.Models
{
	public class Pastry : BakeryItem
	{
		public override int BasePrice => 2;
		public override int FreeEvery => 4;
		public Pastry(int amount)
		{
			Amount = amount;
		}
	}
}