// See https://aka.ms/new-console-template for more information
void FizzBuzz()
{
    int i = 1;
    while (i <= 100)
    {
        if (i % 3 != 0 && i % 5 != 0) Console.WriteLine(i.ToString());
        else if (i % 3 == 0 && i % 5== 0) Console.WriteLine("FizzBuzz");
        else if (i % 3 == 0 && i % 5 != 0) Console.WriteLine("Fizz");
        else if (i % 3 != 0 && i % 5 == 0) Console.WriteLine("Buzz");
        i++;
    }

}

FizzBuzz();


