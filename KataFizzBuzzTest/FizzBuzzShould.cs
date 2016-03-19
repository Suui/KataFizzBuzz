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
	}

	internal class FizzBuzz
	{
		public static string Say(int number)
		{
			return number.ToString();
		}
	}
}
