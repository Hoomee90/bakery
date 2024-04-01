using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
	[TestClass]
	public class BreadTests
	{
		[TestMethod]
		public void BreadConstructor_CreateInstanceOfBread_Bread()
		{
			Bread newBread = new(0);
			Assert.AreEqual(typeof(Bread), newBread.GetType());
		}
		
		[TestMethod]
		public void GetBasePrice_ReturnsBasePrice_Int()
		{
			Bread newBread = new(0);
			int result = newBread.BasePrice;
			Assert.AreEqual(5, result);
		}
		
		[TestMethod]
		public void GetAmount_ReturnsAmount_Int()
		{
			int expected = 3;
			Bread newBread = new(expected);
			int result = newBread.Amount;
			Assert.AreEqual(expected, result);
		}
		
		[TestMethod]
		public void SetAmount_SetsValueOfAmount_Void()
		{
			Bread newBread = new(3);
			int newAmount = 4;
			newBread.Amount = newAmount;
			Assert.AreEqual(newAmount, newBread.Amount);
		}
		
		[TestMethod]
		public void GetFreeEvery_ReturnsFreeEvery_Int()
		{
			Bread newBread = new(0);
			int result = newBread.FreeEvery;
			Assert.AreEqual(3, result);
		}
		
		[TestMethod]
		public void FindTotalCost_ReturnsCalculatedCost_Int()
		{
			Bread newBread = new(2);
			int result = newBread.FindTotalCost();
			Assert.AreEqual(10, result);
		}
	}
}