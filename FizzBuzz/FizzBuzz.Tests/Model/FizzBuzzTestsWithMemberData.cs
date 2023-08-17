using FizzBuzz.Shared.Model;
using FizzBuzz.Shared.Tests.Helpers;

namespace FizzBuzz.Shared.Tests.Model
{
    [Collection(nameof(SystemTestCollectionDefinition))]
    public class FizzBuzzTestsWithMemberData
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void FizzBuzz_Tests_WithMemberData(int input, string expectedOutput)
        {
            // Arrange


            // Act
            string output = FizzBuzzProcessor.ProcessInteger(input);

            // Assert
            Assert.Equal(expectedOutput, output);
        }

        public static List<object[]> Data()
        {
            return new List<object[]>
            {
                new object[] { RandomIntegerGenerator.GenerateIntegerDivisibleBy(new int[] { 3 }, 1, 100, new int[] { 5 }), "Fizz" },
                new object[] { RandomIntegerGenerator.GenerateIntegerDivisibleBy(new int[] { 5 }, 1, 100, new int[] { 3 }), "Buzz" },
                new object[] { RandomIntegerGenerator.GenerateIntegerDivisibleBy(new int[] { 3, 5 }, 1, 100), "FizzBuzz" }
            };
        }
    }
}
