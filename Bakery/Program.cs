using System;
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
				
				static void ChooseAmount(string orderType)
				{

				}
			}
		}
	}
}