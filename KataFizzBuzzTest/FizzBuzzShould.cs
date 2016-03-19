using FluentAssertions;
using KataFizzBuzz;
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

		[Test]
		public void say_buzz_when_the_number_is_divisble_by_five()
		{
			FizzBuzz.Say(5).Should().Be("Buzz");
		}

		[Test]
		public void say_fizzbuzz_when_the_number_is_divisible_by_three_and_five()
		{
			FizzBuzz.Say(3 * 5).Should().Be("FizzBuzz");
		}
	}
}
