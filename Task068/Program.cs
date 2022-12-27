/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

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

int AkkermanFunction (int m, int n)
{
    if (m == 0) return n+1;
    else if ((m > 0) && (n == 0)) return AkkermanFunction(m-1, 1);
    else if ((m > 0) && (n > 0))  return AkkermanFunction(m-1, AkkermanFunction(m, n-1));
    else return 0;
}

int m = GetNumber("Enter the M number");
int n = GetNumber("Enter the N number");

Console.WriteLine($"{AkkermanFunction(m, n)}");