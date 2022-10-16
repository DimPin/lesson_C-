/* Задача 1 Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее. */

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"{num1} more than {num2}");
// }
// else if (num2 > num1)
// {
//     Console.WriteLine($"{num2} more than {num1}");
// }
// else
// {
//     Console.WriteLine($"{num1} = {num2}");
// }

/* Задача 2 Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из 
этих чисел.*/

// Console.Write("Input first number: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number: ");
// int n3 = Convert.ToInt32(Console.ReadLine());

// if (n1 > n2 && n1 > n3)
// {
//     Console.WriteLine($"{n1} more then {n2} and {n3}");
// }
// else if (n2 > n1 && n2 > n3)
// {
//     Console.WriteLine($"{n2} more then {n1} and {n3}");
// }
// else if (n3 > n1 && n3 > n2)
// {
//     Console.WriteLine($"{n3} more then {n1} and {n2}");
// }
// else
// {
//     Console.WriteLine($"{n1} = {n2} = {n3}");
// }

/* Задача 3 Напишите программу, которая на вход 
принимает число и выдаёт, является ли 
число чётным (делится ли оно на два без остатка). */

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// {
//     Console.WriteLine($"{num} is even");
// }
// else
// {
//     Console.WriteLine($"{num} is not even");
// }

/* Задача 4 Напишите программу, которая на 
вход принимает число (N), а на выходе показывает 
все чётные числа от 1 до N. */

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}