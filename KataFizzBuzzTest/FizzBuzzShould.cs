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
			1.FizzBuzzed().Should().Be("1");
		}

		[Test]
		public void say_fizz_when_the_number_is_divisible_by_three()
		{
			3.FizzBuzzed().Should().Be("Fizz");
		}

		[Test]
		public void say_buzz_when_the_number_is_divisble_by_five()
		{
			5.FizzBuzzed().Should().Be("Buzz");
		}

		[Test]
		public void say_fizzbuzz_when_the_number_is_divisible_by_three_and_five()
		{
			15.FizzBuzzed().Should().Be("FizzBuzz");
		}
	}
}
