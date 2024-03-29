namespace Bakery.Models
{
	public abstract class BakeryItem
	{
		protected int _basePrice;
		public int BasePrice 
		{ 
			get { return _basePrice; }
		}
	}
}