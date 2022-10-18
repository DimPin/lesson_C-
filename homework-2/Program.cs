/* Задча 1 Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа. */

int SecondNumber(int num)
{
    int res = (num / 10) % 10;
    return res;
}

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Second number {number} is {SecondNumber(number)}");

/* Задача 2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. */

int thirdNumber(int num)
{
    int res = -1;
    string strNum = Convert.ToString(num);

    if (strNum.Length == 3)
    {
        res = num % 10;
        return res;
    }
    else if (strNum.Length > 3)
    {
        int divend = strNum.Length - 3;
        int i = 0;
        while (i < divend)
        {
            num = num / 10;
            i++;
        }
        res = num % 10;
        return res;
    }
    else
    {
        return res;
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Third number {number} is {thirdNumber(number)}");

/* Задача 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным. */

bool IsWeekendDay(int day)
{
    if (day > 5 && day < 8)
        return true;
    else
        return false;
}

Console.Write("Input number of the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The day number {day} is weekend - {IsWeekendDay(day)}");