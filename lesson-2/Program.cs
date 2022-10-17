int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100, 1000);
int newNum = CutDigit(randNum);
Console.WriteLine($"New version of {randNum} is {newNum}");

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.