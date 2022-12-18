/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
x = b2-b1/k1-k2;
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
//получить число с консоли
double GetNumber(string message)
{
    double result;

    while(true)
    {
        Console.WriteLine(message);
        
        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}

double k1 = GetNumber("Enter k1");
double b1 = GetNumber("Enter b1");
double k2 = GetNumber("Enter k2");
double b2 = GetNumber("Enter b2");

if (k1 == k2)
    Console.WriteLine("parallel lines");
else
{
    double x0 = (b2 - b1) / (k1 - k2);
    double y0 = k1 * x0 + b1;
    Console.WriteLine($"intersection point [{x0}, {y0}]");
}