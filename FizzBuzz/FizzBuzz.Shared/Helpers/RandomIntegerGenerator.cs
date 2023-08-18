using System;
using System.Runtime.InteropServices;

namespace FizzBuzz.Shared.Helpers
{
    public class RandomIntegerGenerator
    {
        public static int Generate(int[] factors, int minValue, int maxValue, int[]? nonFactors = null)
        {
            nonFactors ??= new int[] { 0 };

            var random = new Random();

        startLoopToFindTheMatchingInteger:
            bool[] areEligibleFactors = new bool[factors.Length];

            int returnInteger = random.Next(minValue, maxValue);
            for (int d = 0; d < factors.Length; d++)
            {
                for (int nf = 0; nf < nonFactors.Length; nf++)
                {
                    while (!areEligibleFactors[d])
                    {
                        bool isFactor = returnInteger % factors[d] == 0;
                        bool isNotFactor = (nonFactors[nf] == 0) || returnInteger % nonFactors[nf] != 0;

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

        public static int GenerateByBrimmingDev(int[] factors, int minValue, int maxValue, int[]? nonFactors = null)
        {
            var factorsSet = CreateHashSet(factors, minValue, maxValue);
            var nonFactorsSet = CreateHashSet(nonFactors, minValue, maxValue);

            var random = new Random();

            while (true)
            {
                int possibleInt = random.Next(minValue, maxValue);

                if (factorsSet.Contains(possibleInt) && (!nonFactorsSet.Contains(possibleInt) || !nonFactorsSet.Any()))
                {
                    return possibleInt;
                }
            }
        }

        private static HashSet<int> CreateHashSet(int[]? divisors, int minValue, int maxValue)
        {
            var result = new HashSet<int>();
            if (divisors == null) return result;
            for (int num = minValue; num <= maxValue; num++)
            {
                bool isDivisible = true;
                foreach (int divisor in divisors)
                {
                    if (num % divisor != 0)
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible) result.Add(num);
            }
            return result;
        }
    }
}
