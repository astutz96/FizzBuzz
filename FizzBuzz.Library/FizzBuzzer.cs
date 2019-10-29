using System;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            string output = string.Empty;

            if (IsDivisible(input, 3))
                output += "Fizz";
            if (IsDivisible(input, 5))
                output += "Buzz";
            if (string.IsNullOrEmpty(output))
                output = input.ToString();
            return output;
        }

        private static bool IsDivisible(int Dividend, int Divisor)
        {
            return (Dividend % Divisor) == 0;
        }
    }
}
