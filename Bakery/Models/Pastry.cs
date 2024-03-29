namespace Bakery.Models
{
	public class Pastry : BakeryItem
	{
		public Pastry(int amount)
		{
			_basePrice = 2;
			Amount = amount;
		}
	}
}