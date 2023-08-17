﻿namespace FizzBuzz.Shared.Tests.Helpers
{
    internal class RandomIntegerGenerator
    {
        internal static int GenerateIntegerDivisibleBy(int[] factors, int minValue, int maxValue, int[]? notFactors = null)
        {
            notFactors ??= new int[] { 0 };

            // used Shared Properties for thread-safety. Tests execution where stuck with new Random()
            //var random = Random.Shared;
            var random = new Random();

        startLoopToFindTheMatchingInteger:
            bool[] areEligibleFactors = new bool[factors.Length];

            int returnInteger = random.Next(minValue, maxValue);
            for (int d = 0; d < factors.Length; d++)
            {
                for (int nd = 0; nd < notFactors.Length; nd++)
                {
                    while (!areEligibleFactors[d])
                    {
                        bool isFactor = returnInteger % factors[d] == 0;
                        bool isNotFactor = (notFactors[nd] == 0) || returnInteger % notFactors[nd] != 0;
                        
                        if (isFactor && isNotFactor)
                        {
                            areEligibleFactors[d] = true;
                        }
                        else goto startLoopToFindTheMatchingInteger;
                    }
                }
            }
            return returnInteger;
        }
    }
}
