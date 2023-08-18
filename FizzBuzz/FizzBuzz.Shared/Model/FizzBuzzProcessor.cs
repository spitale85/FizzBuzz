using System.Security.Cryptography.X509Certificates;

namespace FizzBuzz.Shared.Model
{
    public class FizzBuzzProcessor
    {
        public static string ProcessInteger(int input)
        {
            if (input % 3 == 0 && input % 5 == 0) return "FizzBuzz";
            else if (input % 3 == 0 && input % 5 != 0) return "Fizz";
            else if (input % 3 != 0 && input % 5 == 0) return "Buzz";
            else return input.ToString();
        }
    }
}
