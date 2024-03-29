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
			Pastry newPastry = new(0);
			Assert.AreEqual(typeof(Pastry), newPastry.GetType());
		}
		
		[TestMethod]
		public void GetBasePrice_ReturnsBasePrice_Int()
		{
			int expected = 2;
			Pastry newPastry = new(0);
			int result = newPastry.BasePrice;
			Assert.AreEqual(expected, result);
		}
		
		[TestMethod]
		public void GetAmount_ReturnsAmount_Int()
		{
			int expected = 7;
			Pastry newPastry = new(expected);
			int result = newPastry.Amount;
			Assert.AreEqual(expected, result);
		}
		
		[TestMethod]
		public void SetAmount_SetsValueOfAmount_Void()
		{
			Pastry newPastry = new(7);
			int newAmount = 6;
			newPastry.Amount = newAmount;
			Assert.AreEqual(newAmount, newPastry.Amount);
		}
	}
}