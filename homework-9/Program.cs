/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
от N до 1. Выполнить с помощью рекурсии. */

void WriteAllNumbers(int n)
{
    if (n > 1)
    {
        Console.Write(n + " ");
        WriteAllNumbers(n - 1);
    }
    else Console.Write(n);
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
WriteAllNumbers(n);

/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
промежутке от M до N. */

int SumNumbers(int m, int n)
{
    if (m != n) return SumNumbers(m + 1, n) + m;
    else return m;
}

Console.Write("Input first number: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers(m1, n1));

/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
числа m и n. */

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}

Console.Write("Input first number: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(m2, n2));