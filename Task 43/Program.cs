// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FindX(double a1, double c1, double a2, double c2)
{
    double x = 0;
    {
        x = (c1 - c2) / (a2 - a1);  
    }
    return x;
}

double FindY(double a2, double c2, double x)
{
    double y = 0;
    {
        y = a2 * x + c2;
    }
    return y;
}

Console.Clear();
Console.WriteLine("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);
if(k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны друг другу");
}
else
{
double x = FindX(k1, b1, k2, b2);
double y = FindY(k2, b2, x);
Console.WriteLine($"Точка пересечения прямых - {(x, y)}");
}
