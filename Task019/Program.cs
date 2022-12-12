/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

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

bool IsPolyndrome (int number) 
{
    int polyNumber = 0;
    int rightNumber = number;
    while (number > 0)
    {
        polyNumber = polyNumber * 10 + number % 10;
        number = number / 10;
    }
    return polyNumber == rightNumber;
}

int number = GetNumber("Enter the number");
Console.WriteLine(IsPolyndrome(Math.Abs(number)));