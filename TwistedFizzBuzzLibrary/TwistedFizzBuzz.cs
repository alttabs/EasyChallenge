namespace TwistedFizzBuzzLibrary
{
  public class TwistedFizzBuzz
  {
    public static string[] GetFizzBuzzOutput(int start, int end, int[] divisors = null, string[] tokens = null)
    {
      if (divisors == null || tokens == null || divisors.Length != tokens.Length)
      {
        divisors = new int[] { 3, 5 };
        tokens = new string[] { "Fizz", "Buzz" };
      }

      var results = new List<string>();

      for (int i = start; i <= end; i++)
      {
        results.Add(GetFizzBuzzValue(i, divisors, tokens));
      }

      return results.ToArray();
    }

    public static string[] GetFizzBuzzOutput(int[] numbers, int[] divisors = null, string[] tokens = null)
    {
      if (divisors == null || tokens == null || divisors.Length != tokens.Length)
      {
        divisors = new int[] { 3, 5 };
        tokens = new string[] { "Fizz", "Buzz" };
      }

      return numbers.Select(num => GetFizzBuzzValue(num, divisors, tokens)).ToArray();
    }

    private static string GetFizzBuzzValue(int number, int[] divisors, string[] tokens)
    {
      string result = string.Empty;

      for (int i = 0; i < divisors.Length; i++)
      {
        if (number % divisors[i] == 0)
        {
          result += tokens[i];
        }
      }

      return string.IsNullOrEmpty(result) ? number.ToString() : result;
    }
  }
}
