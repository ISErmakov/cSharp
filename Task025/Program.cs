/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
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

int Pow(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

int numberA = GetNumber("Enter A number");
int numberB = GetNumber("Enter B number");
Console.WriteLine(Pow(numberA,numberB));