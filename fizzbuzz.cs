using static System.Console;

// numbers 1 to 100
// when we get a number divisible by 3 say Fizz
// when we get a number divisible by 5 say Buzz
// when we get a number divisible by 15 say FizzBuzz
// otherwise print the number

for (var num = 1; num <= 100; num++)
{
    // 1
    // 2
    // 3
    // 4
    // 5

if (num % 15 == 0)
{
    Write("FizzBuzz");
}
else if (num % 3 == 0)
{
    Write("Fizz");
}
else if (num % 5 == 0)
{
    Write("Buzz");
}
else
{
    Write(num);
}
}

