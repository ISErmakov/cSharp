/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет*/

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 1)
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

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1,100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

string GetValue(int[,] matrix, int x, int y)
{
    if ((x < matrix.GetLength(0)) && (y < matrix.GetLength(1))) return matrix[x-1, y-1].ToString();
    else return "Такого числа в массеве нет";
};

int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);

int x = GetNumber("Веедите номер строки");
int y = GetNumber("Введите номер столбца");
Console.WriteLine(GetValue(matrix, x, y));
