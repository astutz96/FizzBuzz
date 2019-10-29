using System;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            string output = string.Empty;

            if (IsDivisibleBy3(input))
                output += "Fizz";
            if (IsDivisibleBy5(input))
                output += "Buzz";
            if (string.IsNullOrEmpty(output))
                output = input.ToString();
            return output;
        }

        private static bool IsDivisibleBy3(int input)
        {
            return (input % 3) == 0;
        }

        private static bool IsDivisibleBy5(int input)
        {
            return (input % 5) == 0; 
        }
    }
}
