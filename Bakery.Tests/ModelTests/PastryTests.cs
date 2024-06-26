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
		
		[TestMethod]
		public void GetFreeEvery_ReturnsFreeEvery_Int()
		{
			Pastry newPastry = new(0);
			int result = newPastry.FreeEvery;
			Assert.AreEqual(4, result);
		}
		
		[TestMethod]
		public void FindTotalCost_ReturnsCalculatedCost_Int()
		{
			Pastry newPastry = new(3);
			int result = newPastry.FindTotalCost();
			Assert.AreEqual(6, result);
		}
		
		[TestMethod]
		public void FindTotalCost_AdjustsForBuyOneGetOne_Int()
		{
			Pastry newPastry = new(7);
			int result = newPastry.FindTotalCost();
			Assert.AreEqual(12, result);
		}
		
		[TestMethod]
		public void FindTotalCost_WorksWithHighAmounts_Int()
		{
			Pastry newPastry = new(160);
			int result = newPastry.FindTotalCost();
			Assert.AreEqual(240, result);
		}
	}
}