/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
строки двумерного массива. */

int[,] CreateIntArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    return array;
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

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

// Console.Write("Input rows: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] arrayIntRandom = CreateIntArray(r, c, min, max);
// ShowIntArray(arrayIntRandom);

// ChangeArray(arrayIntRandom);
// ShowIntArray(arrayIntRandom);

/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
наименьшей суммой элементов. */

int SearchMaxSum(int[,] array)
{
    int size = array.GetLength(0);
    int[] sumArray = new int[size];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i] += array[i, j];
        }
    }

    int rowIndex = 0;
    int maxSum = sumArray[0];

    for (int i = 1; i < sumArray.Length; i++)
    {
        if (maxSum < sumArray[i])
        {
            rowIndex = i;
            maxSum = sumArray[i];
        }
    }
    return rowIndex;
}

// Console.WriteLine($"Max sum row index is: {SearchMaxSum(arrayIntRandom)}");

/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

int[,] matrix1 = CreateIntArray(2, 2, 1, 10);
int[,] matrix2 = CreateIntArray(2, 2, 1, 10);
// ShowIntArray(matrix1);
// ShowIntArray(matrix2);

int[,] MultiMatrix(int[,] array1, int[,] array2)
{
    int[,] arrayMulti = new int[2, 2];

    arrayMulti[0, 0] = array1[0, 0] * array2[0, 0] + array1[0, 1] * array2[1, 0];
    arrayMulti[0, 1] = array1[0, 0] * array2[0, 1] + array1[0, 1] * array2[1, 1];
    arrayMulti[1, 0] = array1[1, 0] * array2[0, 0] + array1[1, 0] * array2[1, 0];
    arrayMulti[1, 1] = array1[1, 0] * array2[0, 1] + array1[1, 1] * array2[1, 1];

    return arrayMulti;
}

// ShowIntArray(MultiMatrix(matrix1, matrix2));

/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2 */

int[,,] CreateArray3d()
{
    int[,,] array3d = new int[2, 2, 2];
    int count = 10;

    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i, j, k] = count;
                count++;
            }
        }
    }

    return array3d;
}

void ShowArray3d(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

// ShowArray3d(CreateArray3d());

/* Напишите программу, которая заполнит спирально массив 4 на 4. */

int[,] arrayFourFour = new int[4, 4];