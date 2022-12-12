/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
int GetNumber (string message) 
{
    bool isCurrect = false;
    int result = 0;
    while (!isCurrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(),out result) && (result > 0))  
        {
            isCurrect = true;
        }
        else 
        {
            Console.WriteLine("not correct number");
        }
    }
    return result;
}


void Cube (int number) 
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Cube(GetNumber("Enter the nubmer"));