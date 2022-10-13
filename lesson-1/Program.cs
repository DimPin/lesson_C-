// Задача 1

/* Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if (quad2 == n1)
{
    Console.WriteLine($"Number {n1} is a square of {n2}");
}
else
{
    Console.WriteLine($"Number {n1} is not a square of {n2}");
} */

// Задача 2

/* Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while (current <= number)
{
    Console.Write($"{current} ");
    current++;
} */

/* Задача 3 Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает последнюю цифру 
этого числа. */

Console.Write("Input tree-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;
Console.WriteLine($"Last digit of {number} is {result}");