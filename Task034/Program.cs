/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.Clear();

//получить размерность массива с консоли
int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}

//получить заполненный массив рандомными числами
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }

    return array;
}

//получить количество четных(1й аргумент) и количество нечетных(2й аргумент) массива
(int, int) NumberOfEvenOdd (int [] array)
{
    int countOfEven = 0;
    int countOfOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
            countOfEven++;
        else countOfOdd++;
    }
    return (countOfEven, countOfOdd);
}

int[] array = InitArray(GetNumber("Enter massive size"));
Console.WriteLine(string.Join(" ", array));
(int coe, int coo) = NumberOfEvenOdd(array);
Console.WriteLine($"Even numbers - {coe}, Odd numbers - {coo}");