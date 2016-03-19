using FluentAssertions;
using NUnit.Framework;


namespace KataFizzBuzzTest
{	
	[TestFixture]
	class FizzBuzzShould
	{	
		[Test]
		public void say_the_number_when_it_is_not_divisible_by_three()
		{
			FizzBuzz.Say(1).Should().Be("1");
		}

		[Test]
		public void say_fizz_when_the_number_is_divisible_by_three()
		{
			FizzBuzz.Say(3).Should().Be("Fizz");
		}
	}

	internal class FizzBuzz
	{
		public static string Say(int number)
		{
			if (number % 3 == 0) return "Fizz";
			return number.ToString();
		}
	}
}
