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
			Bread newBread = new();
			Assert.AreEqual(typeof(Bread), newBread.GetType());
		}
		
		[TestMethod]
		public void GetBasePrice_ReturnsBasePrice_Int()
		{
			int expected = 5;
			Bread newBread = new();
			int result = newBread.BasePrice;
			Assert.AreEqual(expected, result);
		}
	}
}