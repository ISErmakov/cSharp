/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
double GetNumber (string message) 
{
    bool isCurrect = false;
    double result = 0;
    while (!isCurrect)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(),out result)) 
        {
            isCurrect = true;
        }
        else 
        {
            Console.WriteLine("not correct number");
        }
    }
    return result;
}

double Distance (double x1, double y1, double z1, double x2, double y2, double z2) 
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}

double x1 = GetNumber("Enter x1");
double y1 = GetNumber("Enter y1");
double z1 = GetNumber("Enter z1");

double x2 = GetNumber("Enter x2");
double y2 = GetNumber("Enter y2");
double z2 = GetNumber("Enter z2");

Console.WriteLine("{0:0.00}", Distance(x1, y1, z1, x2, y2, z2));