namespace KataFizzBuzz
{
	public class FizzBuzz
	{
		public static string Say(int number)
		{
			if (IsDivisibleByThree(number)) return "Fizz";
			return number.ToString();
		}

		private static bool IsDivisibleByThree(int number)
		{
			return number % 3 == 0;
		}
	}
}