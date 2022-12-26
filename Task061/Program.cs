/*
Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
задачка со звездочкой*/


int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
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

int[,] InitPascalMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    matrix[0,columns/2] = 1;
    for (int i = 1; i < rows; i++)
    {
        //matrix[i,0] = 1;
        //matrix[i,columns-1] = 1;
        for (int j = 1; j < columns-1; j++)
        {
            matrix[i, j] = matrix[i-1,j-1] + matrix[i-1,j+1];
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
            if (matrix[i,j] == 0)
                Console.Write("   ");
            else
                Console.Write(matrix[i,j].ToString("000"));
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

int n = GetNumber("Введите размер треугольника Паскаля");
PrintMatrix(InitPascalMatrix(n,2*n+1));