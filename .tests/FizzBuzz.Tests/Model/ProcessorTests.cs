using FizzBuzz.Shared.Model;

namespace FizzBuzz.Shared.Tests.Model
{
    public class ProcessorTests
    {
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [Theory]
        public void ReturnsFizzGivenAMultipleOfThree(int number)
        {
            // Act
            string output = Processor.ProcessInteger(number);

            // Assert
            Assert.Equal("Fizz", output);
        }

        [InlineData(5)]
        [InlineData(10)]
        [InlineData(5)]
        [Theory]
        public void ReturnsFizzGivenAMultipleOfFive(int number)
        {
            // Act
            string output = Processor.ProcessInteger(number);

            // Assert
            Assert.Equal("Buzz", output);
        }

        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        [Theory]
        public void ReturnsFizzGivenAMultipleOfThreeAndFive(int number)
        {
            // Act
            string output = Processor.ProcessInteger(number);

            // Assert
            Assert.Equal("FizzBuzz", output);
        }

        [InlineData(1)]
        [InlineData(7)]
        [InlineData(8)]
        [Theory]
        public void ReturnsNumberGivenANonMultipleOfThreeOrFive(int number)
        {
            // Act
            string output = Processor.ProcessInteger(number);

            // Assert
            Assert.Equal(number.ToString(), output);
        }
    }
}
