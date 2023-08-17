namespace FizzBuzz.Shared.Tests.Helpers
{
    internal class RandomIntegerGenerator
    {
        internal static int GenerateIntegerDivisibleBy(int[] dividers, int minValue, int maxValue, int[]? notDividers = null)
        {
            notDividers ??= new int[] { 0 };

            // used Shared Properties for thread-safety. Tests execution where stuck with new Random()
            //var random = Random.Shared;
            var random = new Random();

        startLoopToFindTheMatchingInteger:
            bool[] areEligibleDividers = new bool[dividers.Length];

            int returnInteger = random.Next(minValue, maxValue);
            for (int d = 0; d < dividers.Length; d++)
            {
                for (int nd = 0; nd < notDividers.Length; nd++)
                {
                    while (!areEligibleDividers[d])
                    {
                        bool isDividible = returnInteger % dividers[d] == 0;
                        bool isNotDividible = (notDividers[nd] == 0) || returnInteger % notDividers[nd] != 0;
                        
                        if (isDividible && isNotDividible)
                        {
                            areEligibleDividers[d] = true;
                        }
                        else goto startLoopToFindTheMatchingInteger;
                    }
                }
            }
            return returnInteger;
        }
    }
}
