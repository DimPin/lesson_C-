/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
натуральную степень B. */

int NumberPow(int a, int b)
{
    int count = a;

    for (int i = 1; i < b; i++)
    {
        a *= count;
    }
    return a;
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input degree of number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number {a} in {b} degree is {NumberPow(a, b)}");

/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */

int SumNumbers(int num)
{
    int res = 0;

    while(num > 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum numbers {num} is {SumNumbers(num)}");

/* Напишите программу, которая задаёт массив из m элементов и выводит их на экран. */

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
}

Console.Write("Input number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 99;

int[] myArray = CreateRandomArray(m, min, max);
ShowArray(myArray);