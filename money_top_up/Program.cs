using System;

namespace money_top_up
{
	class MoneyBox
	{

		public double savings { get; set; }

		public MoneyBox(double savings = 0)
		{
			this.savings = savings;
		}

		public double moneyRemainder(double money)
		{
			var pennies = money - Math.Truncate(money);
			double cashSaving = pennies == 0 ? 0 : 1 - pennies;
			addToSavings(cashSaving);
			return cashSaving;
		}

		private double addToSavings(double cashRemainder)
		{
			this.savings += cashRemainder;
			return savings;
		}

		public double checkSavings()
		{
			return savings;
		}

		public static void Main(string[] args)
		{
			MoneyBox piggyBank = new MoneyBox();

			while (piggyBank.savings < 10)
			{
				Console.WriteLine("How much money did you spend on that last perchase?");
				string price = Console.ReadLine();

				double remainder = piggyBank.moneyRemainder(double.Parse(price));

				Console.WriteLine("You have saved £{0} from that perchase!", Math.Round(remainder, 2));

				Console.WriteLine("Your current savings are £{0}", piggyBank.checkSavings());
			}

			Console.WriteLine("You have saved over £10, go out and celebrate!");

		}
	}
}
