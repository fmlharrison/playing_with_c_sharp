using System;

namespace money_top_up
{
	class MoneyBox
	{

		public double moneyRemainder(double money)
		{
			var pennies = money - Math.Truncate(money);
			return 1 - pennies;
		}

		public static void Main(string[] args)
		{
			MoneyBox savings = new MoneyBox();

			Console.WriteLine("How much money did you spend on that last perchase?");
			string price = Console.ReadLine();

			double remainder = savings.moneyRemainder(double.Parse(price));

			Console.WriteLine("You have saved {0}p from that perchase!", remainder);
		}
	}
}
