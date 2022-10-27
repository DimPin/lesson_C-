/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. */

bool IsPolindrom(int num)
{
    int number = num;
    int reverse = 0;

    while (number > 0)
    {
        int temp = number % 10;
        reverse = reverse * 10 + temp;
        number /= 10;
    }

    if (reverse == num)
        return true;
    else
        return false;
}

Console.Write("Input five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number {number} is polindrom: {IsPolindrom(number)}");

/* Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N. */

void NumbersCube(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
NumbersCube(num);

/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве. */

double CalcDist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dx = x2 - x1;
    double dy = y2 - y1;
    double dz = z2 - z1;

    return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2) + Math.Pow(dz, 2));
}

Console.Write("Input x 1st point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y 1st pint: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z 1st pint: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x 2nd point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y 2nd point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z 2nd point: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance between points with coordinates {x1}, {y1}, {z1} and {x2}, {y2}, {z2} is {Math.Round(CalcDist(x1, y1, z1, x2, y2, z2), 2)}");