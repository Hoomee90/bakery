namespace Bakery.Models
{
	public class Bread : BakeryItem
	{
		public Bread(int amount)
		{
			_basePrice = 5;
			Amount = amount;
		}
	}
}