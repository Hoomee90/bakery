using System;
using System.ComponentModel.Design;
using Bakery.Models;

namespace Bakery
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
			Console.WriteLine("Welcome to Pierre's Bakery");
			Console.Write("The freshest baked goods this side of ");
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("THE VOID");
			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
			Console.WriteLine("What would you like to order?");
			MakeOrder();
		}
		
		static void MakeOrder()
		{
			Console.WriteLine("Bread is $5 a loaf");
			Console.WriteLine("But there's a special deal: Buy 2 loaves, get 1 free");
			Console.WriteLine("Each pastry is $2");
			Console.WriteLine("But there's ANOTHER special deal: Buy 3 pastries, get 1 free");
			Console.WriteLine("Type 'bread' or 'pastry' to chose what to order");
			string userResponse = Console.ReadLine().ToLower();
			if (userResponse != "bread" && userResponse != "pastry")
			{
				Console.WriteLine("I'm sorry. We don't understand");
				Console.WriteLine("Please try again");
				MakeOrder();
			}
			else
			{
				ChooseAmount(userResponse);
			}
		}
			
		static void ChooseAmount(string orderType)
		{
			Console.WriteLine("How many orders of {0} would you like?", orderType);
			string amount = Console.ReadLine();
			if (int.TryParse(amount, out int number))
			{
				BakeryItem order = orderType == "bread" ? new Bread(number) : new Pastry(number);
				Console.WriteLine("That amount will cost ${0}", order.FindTotalCost());
				Console.WriteLine("Would you like to add our other product to your order?");
				Console.WriteLine("'y' for yes, anything else to move to checkout");
				string userResponse = Console.ReadLine().ToLower();
				if (userResponse == "y")
				{
					if (orderType == "bread")
					{
						ChooseAmount("pastry", order);
					}
					else
					{
						ChooseAmount("bread", order);
					}
				}
				else
				{
					Checkout();
				}
			}
			else
			{
				Console.WriteLine("I'm sorry. We can't provide that amount of {0}", orderType);
				Console.WriteLine("Please try again");
				ChooseAmount(orderType);
			}
		}
		
		static void ChooseAmount(string orderType, BakeryItem previousOrder)
		{
			Console.WriteLine("How many orders of {0} would you like?", orderType);
			string amount = Console.ReadLine();
			if (int.TryParse(amount, out int number))
			{
				BakeryItem order = orderType == "bread" ? new Bread(number) : new Pastry(number);
				Console.WriteLine("That order will add ${0} to your total", order.FindTotalCost());
				Checkout();
			}
			else
			{
				Console.WriteLine("I'm sorry. We can't provide that amount of {0}", orderType);
				Console.WriteLine("Please try again");
				ChooseAmount(orderType, previousOrder);
			}
		}
		
		static void Checkout()
		{
			
		}
	}
}