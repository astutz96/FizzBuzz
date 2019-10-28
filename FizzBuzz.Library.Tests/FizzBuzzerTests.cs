using NUnit.Framework;

namespace FizzBuzz.Library.Tests
{
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(1,2,4)]int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_When3_ReturnsFizz()
        {
            int input = 3;
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }
    }
}