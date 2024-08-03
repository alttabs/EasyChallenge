using System;
using Xunit;
using TwistedFizzBuzzLibrary;

namespace TwistedFizzBuzzTests
{
    public class TwistedFizzBuzzTests
    {
        [Fact]
        public void StandardFizzBuzzTest()
        {
            var results = TwistedFizzBuzz.GetFizzBuzzOutput(1, 15);
            var expected = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            Assert.Equal(expected, results);
        }

        [Fact]
        public void TestGetFizzBuzzOutput_EmptyArray()
        {
            var numbers = new int[] { };
            var expected = new string[] { };

            var results = TwistedFizzBuzz.GetFizzBuzzOutput(numbers);

            Assert.Equal(expected, results);
        }

        [Fact]
        public void NonSequentialNumbersTest()
        {
            int[] numbers = { -5, 6, 300, 12, 15 };
            var results = TwistedFizzBuzz.GetFizzBuzzOutput(numbers);
            var expected = new string[] { "Buzz", "Fizz", "FizzBuzz", "Fizz", "FizzBuzz" };
            Assert.Equal(expected, results);
        }

        [Fact]
        public void TestGetFizzBuzzOutput_NoFizzBuzz()
        {
            var numbers = new int[] { 1, 2, 4, 7, 8 };
            var expected = new string[] { "1", "2", "4", "7", "8" };

            var results = TwistedFizzBuzz.GetFizzBuzzOutput(numbers);

            Assert.Equal(expected, results);
        }
    }
}
