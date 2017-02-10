using FluentAssertions;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzShould
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "buzz")]
        [InlineData(6, "fizz")]
        [InlineData(15, "fizzbuzz")]
        [InlineData(99, "fizz")]
        public void return_right_data_given_a_sample(int input, string expected)
        {
            var fizzBuzz = new FizzBuzzParser();
            fizzBuzz.Parse(input).Should().Be(expected);
        }
    }
}