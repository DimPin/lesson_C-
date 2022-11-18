/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. */

string numbers = string.Empty;
bool isExit = false;
int countNum = 0;

while (!isExit)
{
    Console.Write("Input next number or press q for exit: ");
    var inputChar = Console.ReadLine();
    int testInt;

    if (inputChar is not null)
    {
        if (inputChar.StartsWith("q"))
        {
            isExit = true;
        }
        else
        {
            if (int.TryParse(inputChar, out testInt))
            {
                if (testInt > 0)
                {
                    countNum++;
                }
            }
            else
            {
                Console.WriteLine("The entered value is not a number");
            }
            
            numbers += $" {inputChar}";
        }
    }


}

Console.WriteLine($"Inputed numbers: {numbers} -> {countNum}");

/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. */

Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Straight lines are parallel");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"The lines intersect at a point {x}, {y}");
}