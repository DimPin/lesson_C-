int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i ,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Console.Write("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);

/* Задайте двумерный массив размера m на n, каждый элемент в 
массиве находится по формуле: Aij = i+j. Выведите полученный 
массив на экран. */

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i ,j] = i + j;
    
    return array;
}

// Console.Write("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateArray(rows, columns);
// Show2dArray(myArray);

/* Задайте двумерный массив. Найдите элементы, у которых оба 
индекса чётные, и замените эти элементы на их квадраты. */

void ChangeEvenIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
        for (int j = 0; j < array.GetLength(1); j += 2)
            array[i, j] *= array[i, j];
}


// Console.Write("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// ChangeEvenIndex(myArray);
// Show2dArray(myArray);

/* Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) 
и т.д. */

int FindSum(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine(FindSum(myArray));