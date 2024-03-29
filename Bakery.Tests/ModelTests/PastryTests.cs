using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
	[TestClass]
	public class PastryTests
	{
		[TestMethod]
		public void PastryConstructor_CreateInstanceOfPastry_Pastry()
		{
			Pastry newPastry = new();
			Assert.AreEqual(typeof(Pastry), newPastry.GetType());
		}
		
		[TestMethod]
		public void GetBasePrice_ReturnsBasePrice_Int()
		{
			int expected = 2;
			Pastry newPastry = new();
			int result = newPastry.BasePrice;
			Assert.AreEqual(expected, result);
		}
	}
}