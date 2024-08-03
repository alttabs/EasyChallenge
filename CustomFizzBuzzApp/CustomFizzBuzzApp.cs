using System;
using TwistedFizzBuzzLibrary;

namespace CustomFizzBuzzApp
{
  class CustomFizzBuzzApp
  {
    static void Main(string[] args)
    {
      int[] divisors = { 5, 9, 27 };
      string[] tokens = { "Fizz", "Buzz", "Bar" };
      var results = TwistedFizzBuzz.GetFizzBuzzOutput(-20, 127, divisors, tokens);
      foreach (var result in results)
      {
        Console.WriteLine(result);
      }
    }
  }
}
