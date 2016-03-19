namespace KataFizzBuzz
{
	public static class FizzBuzzExtension
	{
		public static string FizzBuzzed(this int number)
		{
			if (number % 3 == 0) return "Fizz";
			return number.ToString();
		}
	}
}