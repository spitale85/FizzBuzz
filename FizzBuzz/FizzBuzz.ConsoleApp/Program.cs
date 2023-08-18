// See https://aka.ms/new-console-template for more information
using FizzBuzz.Shared.Model;

Console.WriteLine("---------------------------------------");
Console.WriteLine("          FizzBuzz Processor           ");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

int[] fizzBuzzIntegers = Enumerable.Range(1, 100).ToArray();

foreach (var integer in fizzBuzzIntegers)
{
    Console.WriteLine(FizzBuzzProcessor.ProcessInteger(integer));
}

Console.WriteLine();
Console.WriteLine("Done!");
Console.ReadLine();