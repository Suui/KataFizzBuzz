namespace KataFizzBuzz
{
	public static class FizzBuzzExtension
	{
		public static string FizzBuzzed(this int number)
		{
			if (number.IsDivisibleByThreeAndFive()) return "FizzBuzz";
			if (number.IsDivisibleByFive()) return "Buzz";
			if (number.IsDivisibleByThree()) return "Fizz";
			return number.ToString();
		}

		private static bool IsDivisibleByThree(this int number)
		{
			return number % 3 == 0;
		}

		private static bool IsDivisibleByFive(this int number)
		{
			return number % 5 == 0;
		}

		private static bool IsDivisibleByThreeAndFive(this int number)
		{
			return number % (3 * 5) == 0;
		}
	}
}