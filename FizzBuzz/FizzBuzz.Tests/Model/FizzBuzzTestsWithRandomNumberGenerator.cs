using FizzBuzz.Shared.Model;
using FizzBuzz.Shared.Tests.Helpers;

namespace FizzBuzz.Shared.Tests.Model
{
    [Collection(nameof(SystemTestCollectionDefinition))]
    public class FizzBuzzTestsWithRandomNumberGenerator
    {
        [Fact]
        public void RandomNumber_DivisibleOnlyByThree_ReturnsFizz()
        {
            // Arrange
            int input = RandomIntegerGenerator.GenerateIntegerDivisibleBy(new int[] { 3 }, 1, 100, new int[] { 5 });

            // Act
            string output = FizzBuzzProcessor.ProcessInteger(input);

            // Assert
            Assert.Equal("Fizz", output);
        }

        [Fact]
        public void RandomNumber_DivisibleOnlyByFive_ReturnsBuzz()
        {
            // Arrange
            int input = RandomIntegerGenerator.GenerateIntegerDivisibleBy(new int[] { 5 }, 1, 100, new int[] { 3 });

            // Act
            string output = FizzBuzzProcessor.ProcessInteger(input);

            // Assert
            Assert.Equal("Buzz", output);
        }

        [Fact]
        public void RandomNumber_DivisibleByThreeAndByFive_ReturnsFizzBuzz()
        {
            // Arrange
            int input = RandomIntegerGenerator.GenerateIntegerDivisibleBy(new int[] { 3, 5 }, 1, 100);

            // Act
            string output = FizzBuzzProcessor.ProcessInteger(input);

            // Assert
            Assert.Equal("FizzBuzz", output);
        }
    }
}
