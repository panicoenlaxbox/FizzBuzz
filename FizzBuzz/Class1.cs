using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzShould
    {
        // return the same number
        // return fizz
        // return buzz
        // return fizzbuzz
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "buzz")]
        [InlineData(6, "fizz")]
        [InlineData(15, "fizzbuzz")]
        [InlineData(99, "fizz")]
        public void return_correct_data_given_a_sample(int input, string expected)
        {
            var fizzBuzz = new FizzBuzzParser();
            fizzBuzz.Parse(input).Should().Be(expected);
        }
    }

    public class FizzBuzzParser
    {
        public string Parse(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "fizzbuzz";
            }
            if (i % 3 == 0)
            {
                return "fizz";
            }
            if (i % 5 == 0)
            {
                return "buzz";
            }
            return i.ToString();
        }
    }
}
