/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве. */

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
    
    Console.WriteLine();
}

int EvenNumbersArray(int[] array)
{
    int res = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            res += 1;
        }
    }
    return res;
}

int[] threeDigitArray = CreateRandomArray(4, 100, 999);
ShowArray(threeDigitArray);
Console.WriteLine($"Even numbers in array is {EvenNumbersArray(threeDigitArray)}");

/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях. */

int SumNumbersArray(int[] array)
{
    int res = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            res += array[i];
        }
    }
    return res;
}

int[] randomArray = CreateRandomArray(4, 1, 100);
ShowArray(randomArray);
Console.WriteLine($"Sum odd numbers array is {SumNumbersArray(randomArray)}");

/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементов массива. */

int MaxMinNumbersArray(int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }

    int res = max - min;
    return res; 
}

int[] array = CreateRandomArray(4, 1, 100);
ShowArray(array);
Console.WriteLine($"Difference max and min array is {MaxMinNumbersArray(array)}");