/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();
int GetNumber (string message) 
{
    bool isCurrect = false;
    int result = 0;
    while (!isCurrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(),out result)) 
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

int number = GetNumber("Enter the number");
Console.WriteLine($"Sum of digits is {Sum(number)}");

int Sum(int a)
{
    int result = 0;
    while (a > 0)
    {
        result += a % 10;
        a /= 10;
    }
    return result;
}