namespace Bakery.Models
{
	public class Bread : BakeryItem
	{
		public override int BasePrice => 5;
		public override int FreeEvery => 3;
		public Bread(int amount)
		{
			Amount = amount;
		}
	}
}