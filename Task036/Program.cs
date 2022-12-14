/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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
        array[i] = rnd.Next(0,10);
    }

    return array;
}

//получить сумму элементов, стоящих на нечетных позициях
int SumOfOddPositionElements (int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i % 2) == 1)
            result += array[i];
    }
    return result;
}

int[] array = InitArray(GetNumber("Enter massive size"));
Console.WriteLine(string.Join(" ", array));
int sum = SumOfOddPositionElements(array);
Console.WriteLine($"Sum of the array elements with odd position - {sum}");