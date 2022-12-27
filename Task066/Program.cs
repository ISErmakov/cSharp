/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Неверная размерность");
        }
    }

    return result;
}

int SumFromMtoN (int m, int n)
{
    if (m == n) return n;
    else return m + SumFromMtoN(m+1, n);
}

int m = GetNumber("Enter the M number");
int n = GetNumber("Enter the N number");

Console.WriteLine($"{SumFromMtoN(m, n)}");