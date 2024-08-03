using System;
using TwistedFizzBuzzLibrary;

namespace StandardFizzBuzzApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var results = TwistedFizzBuzz.GetFizzBuzzOutput(1, 100);
      foreach (var result in results)
      {
        Console.WriteLine(result);
      }
    }
  }
}
