/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

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
double[] InitArray(int dimension)
{
    double[] array = new double[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.NextDouble() / rnd.NextDouble();
    }

    return array;
}

//получить разницу между максимальным и минимальным элементом массива
double MinMaxDiff (double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
        else if (min > array[i])
            min = array[i];
    }

    return max - min;
}

double[] array = InitArray(GetNumber("Enter massive size"));
//double[] array = {3, 7, 22, 2, 78};
Console.WriteLine(string.Join(" ", array));
double  mmd = MinMaxDiff(array);
Console.WriteLine($"Maximum - Minimum = {mmd}");