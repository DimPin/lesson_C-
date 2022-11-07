/* Напишите программу, которая принимает на вход 
число (А) и выдаёт сумму чисел от 1 до А. */

int FindSum(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}");

/* Напишите программу, которая принимает на вход 
число и выдаёт количество цифр в числе. */

int CountDigit(int number)
{
    int num = Math.Abs(number);
    int count = 0;

    if (num == 0)
    {
        count = 1;
    }

    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The number of digits is {CountDigit(number)}");


/* Напишите программу, которая принимает на вход 
число N и выдаёт произведение чисел от 1 до N. */

int Fact(int number)
{
    int mul = 1;

    if (number >= 1)
    {
        for (int i = 1; i <= number; i++)
        {
            mul *= i;
        }
        return mul;
    }
    else
        return -1;

}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Factorial of {n} is {Fact(n)}");

/* Напишите программу, которая выводит массив из 8 
элементов, заполненный нулями и единицами в 
случайном порядке. */

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    
    Console.Write(" :) \n");
}

Console.Write("Input number of elements: ");
int integer = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(integer, min, max);
ShowArray(myArray);