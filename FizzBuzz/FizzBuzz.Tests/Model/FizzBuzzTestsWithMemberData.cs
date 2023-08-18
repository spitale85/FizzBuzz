using FizzBuzz.Shared.Model;

namespace FizzBuzz.Shared.Tests.Model
{
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
            int a = 3;
            int b = 5;
            int c = 15;

            return new List<object[]>
            {
                new object[] { a, "Fizz" },
                new object[] { b, "Buzz" },
                new object[] { c, "FizzBuzz" }
            };
        }
    }
}
