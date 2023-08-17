using FizzBuzz.Shared.Model;

namespace FizzBuzz.Shared.Tests.Model
{
    [Collection(nameof(SystemTestCollectionDefinition))]
    public class FizzBuzzTestsWithInlineData
    {
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(1, "1")]
        [Theory]
        public void FizzBuzz_Tests_WithInlineData(int input, string expectedOutput)
        {
            // Arrange


            // Act
            string output = FizzBuzzProcessor.ProcessInteger(input);

            // Assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
