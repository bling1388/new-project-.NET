// See https://aka.ms/new-console-template for more information



// Task 1: Print all values from 1 to 255
for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}

// Task 2: Generate 5 random numbers between 10 and 20
Random random = new Random();
int sum = 0;
for (int i = 0; i < 5; i++)
{
    int randomNumber = random.Next(10, 21);
    Console.WriteLine("Random Number: " + randomNumber);
    sum += randomNumber;
}
Console.WriteLine("Sum of Random Numbers: " + sum);

// Task 3: Print values from 1 to 100 that are divisible by 3 OR 5, but NOT both
for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
    {
        Console.WriteLine(i);
    }
}

// Task 4: Print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for multiples of both
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        Console.Write("Fizz");
    }
    if (i % 5 == 0)
    {
        Console.Write("Buzz");
    }
    if (i % 3 != 0 && i % 5 != 0)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}




