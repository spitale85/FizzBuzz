using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace FizzBuzz.ConsoleApp.Tests
{
    public class FizzBuzzConsoleAppTests
    {
        [Fact]
        public void ConsoleOutput_ReturnsAllIntegers()
        {
            // Arrange
            var capturedStdOut = CapturedStdOut(() =>
            {
                RunApp();
            });

            // Act

            // Assert
            Assert.Equal("Welcome, John!", capturedStdOut);
        }

        void RunApp(string[]? arguments = default)
        {
            var entryPoint = typeof(Program).Assembly.EntryPoint!;
            entryPoint.Invoke(null, new object[] { arguments ?? Array.Empty<string>() });
        }

        string CapturedStdOut(Action callback)
        {
            TextWriter originalStdOut = Console.Out;

            using var newStdOut = new StringWriter();
            Console.SetOut(newStdOut);

            callback.Invoke();
            var capturedOutput = newStdOut.ToString();

            Console.SetOut(originalStdOut);

            return capturedOutput;
        }
    }
}