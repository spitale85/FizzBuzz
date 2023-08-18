// See https://aka.ms/new-console-template for more information

using System.Data.SqlTypes;
using FizzBuzz.Shared.Helpers;
using System.Diagnostics;
using System.Runtime.CompilerServices;

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("             Random Integers Performance Tests                  ");
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();

Stopwatch sw = new Stopwatch();

Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine("| Author    | Factors | nonFactors |      Range      |   ms     |");
Console.WriteLine("|----------------------------------------------------------------");

RunPerformanceTest(new int[] { 3 }, 1, 100, "Spitale", new int[] { 5 });
RunPerformanceTest(new int[] { 3 }, 1, 100, "BrimmingDev", new int[] { 5 });
RunPerformanceTest(new int[] { 3 }, 1, 1000000, "Spitale", new int[] { 5 });
RunPerformanceTest(new int[] { 3 }, 1, 1000000, "BrimmingDev", new int[] { 5 });
RunPerformanceTest(new int[] { 3 }, 1, 100000000, "Spitale", new int[] { 5 });
RunPerformanceTest(new int[] { 3 }, 1, 100000000, "BrimmingDev", new int[] { 5 });

RunPerformanceTest(new int[] { 3,5 }, 1, 100, "Spitale");
RunPerformanceTest(new int[] { 3,5 }, 1, 100, "BrimmingDev");
RunPerformanceTest(new int[] { 3,5 }, 1, 100000, "Spitale");
RunPerformanceTest(new int[] { 3,5 }, 1, 100000, "BrimmingDev");
RunPerformanceTest(new int[] { 3,5 }, 1, 100000000, "Spitale");
RunPerformanceTest(new int[] { 3,5 }, 1, 100000000, "BrimmingDev");

Console.WriteLine("|---------------------------------------------------------------|");


Console.WriteLine();
Console.WriteLine("Done!");
Console.ReadLine();

void RunPerformanceTest(int[] factors, int minValue, int maxValue, string author, int[]? nonFactors = null)
{
    switch (author)
    {
        case "Spitale" :
            sw.Start();
            RandomIntegerGenerator.Generate(factors, minValue, maxValue, nonFactors);
            sw.Stop();
            break;

        case "BrimmingDev":
            sw.Start();
            RandomIntegerGenerator.GenerateByBrimmingDev(factors, minValue, maxValue, nonFactors);
            sw.Stop();
            break;
    }

    int nFS;
    if (nonFactors == null) nFS = 0;
    else nFS = nonFactors.Length;
    
    Console.WriteLine($"| {author}\t{factors.Length}\t\t{nFS}\t{maxValue}      \t{sw.ElapsedMilliseconds}\t|");

    sw.Reset();
}
