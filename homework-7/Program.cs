/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. */

double[,] CreateDoubleArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 1);

    return array;
}

void ShowDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

Console.Write("Input rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] arrayRandom = CreateDoubleArray(m, n, minValue, maxValue);

ShowDoubleArray(arrayRandom);

/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет. */

Console.Write("Input index row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input index column: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row > m || column > n)
{
    Console.WriteLine($"Element with index {row}, {column} not found");
}
else
{
    double arrayElemnt = arrayRandom[row, column];
    Console.WriteLine(arrayElemnt);
}

/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
каждом столбце. */

int[,] CreateIntArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    return array;
}

void ArithMean(int[,] array)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            result += array[j, i];
        
        Console.WriteLine(result);
        result /= array.GetLength(1);
        Console.WriteLine($"column {i + 1} -> {result}");
        result = 0;
    }
}

void ShowIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] arrayIntRandom = CreateIntArray(r, c, min, max);
ShowIntArray(arrayIntRandom);
ArithMean(arrayIntRandom);