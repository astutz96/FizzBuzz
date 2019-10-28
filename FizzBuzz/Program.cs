using FizzBuzz.Library;
using System;

namespace FizzBuzz
{
    /*
    * Fizz Buzzer Rules 
    * 
    * Print out number 1 to 100
    * 
    * If Divisible by 3 replace with "Fizz"
    * 
    * If Divisible by 5 replace with "Buzz"
    * 
    * If Divisible by both 3 and 5... replace with "FizzBuzz"
   */
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(i));
            }
            Console.ReadLine();
        }
    }
}
