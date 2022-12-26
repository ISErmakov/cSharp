/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

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
    // стоим на х,у идем вправо/влево/вниз/вверх пока не конец или след элемент не 0;
    int x = 0, y = 0, c = 1;
    matrix[x, y] = c++;

    while (matrix[x, y+1] == 0)
    {
        while (matrix[x, y+1] == 0)
        {
            y++;
            matrix[x, y] = c++;
            if (y == columns - 1) break;
        }

        while (matrix[x+1, y] == 0)
        {
            x++;
            matrix[x, y] = c++;
            if (x == rows - 1) break;
        }

        while (matrix[x, y-1] == 0)
        {
            y--;
            matrix[x, y] = c++;
            if (y == 0) break;
        }

        while (matrix[x-1, y] == 0)
        {
            x--;
            matrix[x, y] = c++;
            if (x == 0) break;
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
            Console.Write(matrix[i,j].ToString("00") + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows1 = GetNumber("Введите количество строк:");
int columns1 = GetNumber("Введите количество столбцов:");
int[,] matrix1 = InitMatrix(rows1, columns1);
PrintMatrix(matrix1);