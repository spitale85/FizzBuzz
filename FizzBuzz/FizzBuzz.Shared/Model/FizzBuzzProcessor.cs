namespace FizzBuzz.Shared.Model
{
    public class FizzBuzzProcessor
    {
        public static string ProcessInteger(int input)
        {
            if (input % 3 == 0 && input % 5 == 0) return "FizzBuzz";
            if (input % 3 == 0 && input % 5 != 0) return "Fizz";
            if (input % 3 != 0 && input % 5 == 0) return "Buzz";
            return input.ToString();
        }
    }
}

