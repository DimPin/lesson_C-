/* Задача 1 Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее. */

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"{num1} more than {num2}");
}
else if (num2 > num1)
{
    Console.WriteLine($"{num2} more than {num1}");
}
else
{
    Console.WriteLine($"{num1} = {num2}");
}