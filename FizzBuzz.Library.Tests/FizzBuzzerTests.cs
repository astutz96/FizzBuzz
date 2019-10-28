using NUnit.Framework;

namespace FizzBuzz.Library.Tests
{
    public class FizzBuzzerTests
    {

        [Test]
        public void Buzzer_When1_Returns1()
        {
            //Arrange
            int input = 1;
            
            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual(1, output);
        }
    }
}