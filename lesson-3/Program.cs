/* Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат 
точек в этой четверти (x и y). */

void ShowQuart(int quartNum)
{
    if (quartNum >= 1 && quartNum <= 4)
    {
        if (quartNum == 1) Console.WriteLine("x > 0 and y > 0");
        else if (quartNum == 2) Console.WriteLine("x < 0 and y > 0");
        else if (quartNum == 3) Console.WriteLine("x < 0 and y < 0");
        else Console.WriteLine("x > 0 and y < 0");
    }
    else
        Console.WriteLine("Error number!");
}

Console.Write("Input a number of quart: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowQuart(num);

/* Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
выдаёт номер четверти плоскости, в которой 
находится эта точка. */

int IsQuart (double x, double y)
{
    int quarter = -1;
    if (x > 0)
    {
        if (y > 0) quarter = 1;
        else quarter = 4;
    }
    else
    {
        if (y > 0) quarter = 2;
        else quarter = 3;
    }
    return quarter;
}

Console.Write("Input x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Point with coordinates {x} and {y} is in {IsQuart(x, y)} quarter");

/* Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между 
ними в 2D пространстве. */

double CalcDist(double x1, double y1, double x2, double y2)
{
    double dx = x2 - x1;
    double dy = y2 - y1;

    return Math.Sqrt(dx * dx + dy * dy);
}

Console.Write("Input x 1st point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y 1st pint: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x 2nd point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y 2nd point: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance between points with coordinates {x1}, {y1} and {x2}, {y2} is {Math.Round(CalcDist(x1, y1, x2, y2), 2)}");


/* Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу квадратов 
чисел от 1 до N. */

void ShowSquares(int limit)
{
    int count = 1;

    while (count <= limit)
    {
        Console.Write($"{count * count} ");
        count++;
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowSquares(number);