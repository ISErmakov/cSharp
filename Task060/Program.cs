/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

int[] InitUniqueArray(int x)
{
    int[] array = new int[x];
    int m;
    Random rnd = new Random();
    for (int i = 0; i < x; i++)
    {
        do 
        {
            m = rnd.Next(1,100);
        } while (Array.IndexOf(array, m) != -1);
        array[i] = m;
    }
    return array;
}

int[,,] InitMatrix3D(int x, int y, int z)
{
    int[,,] matrix = new int[x, y, z];
    int[] array = InitUniqueArray(x * y * z);
    int c = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = array[c++]; 
            }
            
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        
    }
    Console.WriteLine();
}

int length1 = GetNumber("Введите размерность по первому индексу:");
int length2 = GetNumber("Введите размерность по второму индексу:");
int length3 = GetNumber("Введите размерность по третьему индексу:");
int[,,] matrix1 = InitMatrix3D(length1, length2, length3);

PrintMatrix3D(matrix1);
