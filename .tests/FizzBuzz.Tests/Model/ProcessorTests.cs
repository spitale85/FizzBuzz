using FizzBuzz.Shared.Model;

namespace FizzBuzz.Shared.Tests.Model
{
    public class ProcessorTests
    {
        [Fact]
        public void ReturnsFizzGivenAnIntegerDivisibleOnlyByThree()
        {
            // Arrange
            int input = 3;
            
            // Act
            string output = Processor.ProcessInteger(input);

            // Assert
            Assert.Equal("Fizz", output);
        }

        [Fact]
        public void ReturnsBuzzGivenAnIntegerDivisibleOnlyByFive()
        {
            // Arrange
            int input = 5;
            
            // Act
            string output = Processor.ProcessInteger(input);

            // Assert
            Assert.Equal("Buzz", output);
        }

        [Fact]
        public void ReturnsFizzBuzzGivenAnIntegerDivisibleByThreeAndByFive()
        {
            // Arrange
            int input = 15;
            
            // Act
            string output = Processor.ProcessInteger(input);

            // Assert
            Assert.Equal("FizzBuzz", output);
        }

        [Fact]
        public void ReturnsTheSameNumberGivenAnIntegerNotDivisibleByThreeAndByFive()
        {
            // Arrange
            int input = 7;

            // Act
            string output = Processor.ProcessInteger(input);

            // Assert
            Assert.Equal("7", output);
        }
    }
}
