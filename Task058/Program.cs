/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


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
            matrix[i, j] = rnd.Next(1,10);
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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i,k] += matrix1[i,j] * matrix2[j,k];
            }   
        }
    }
    return result;
}

int rows1 = GetNumber("Введите количество строк:");
int columns1 = GetNumber("Введите количество столбцов:");
int[,] matrix1 = InitMatrix(rows1, columns1);
PrintMatrix(matrix1);
Console.WriteLine();

int rows2 = columns1;
int columns2 = GetNumber("Введите количество столбцов 2й матрицы:");
int[,] matrix2 = InitMatrix(rows2, columns2);
PrintMatrix(matrix2);
Console.WriteLine();

int[,] matrix3 = MultiplyMatrix(matrix1, matrix2);
PrintMatrix(matrix3);
Console.WriteLine();
