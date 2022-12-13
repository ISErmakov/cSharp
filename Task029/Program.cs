/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

int len = 8;
int[] array = new int[len];
Random rnd = new Random();

for (int i = 0; i < len; i++)
{
    array[i] = Convert.ToInt32(rnd.Next(0,100));
}

Console.WriteLine(String.Join(" ", array));