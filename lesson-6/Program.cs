int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

// void ReverseArray(int[] array)
// {
//     for (int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }

// Console.Write("Input number of elements: ");
// int integer = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(integer, min, max);
// ShowArray(myArray);
// ReverseArray(myArray);
// ShowArray(myArray);

/* Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: a и b. */

// int[] Fibanachi(int size, int a, int b)
// {
//     int[] array = new int[size];
//     array[0] = a;
//     array[1] = b;

//     if (size >= 3)
//         for (int i = 2; i < array.Length; i++)
//             array[i] = array[i - 2] + array[i - 1];
//     return array;
// }

// Console.Write("Input count numbers Fibonachi: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input first number Fibonachi: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number Fibonachi: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Fibanachi(size, a, b));

/*Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования.*/

// int[] CopyArray(int[] array)
// {
//     int[] newArray = new int[array.Length];

//     for (int i = 0; i < array.Length; i++)
//         newArray[i] = array[i];
//     return newArray;
// }

// int[] array = CreateRandomArray(5, 1, 10);
// ShowArray(array);
// ShowArray(CopyArray(array));

/* Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник с сторонами 
такой длины. */

bool isTriangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        return true;
    else
        return false;
}

Console.Write("Input first side: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second side: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third side: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isTriangle(a, b, c));