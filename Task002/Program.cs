/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Please, enter the first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter the second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"A large number is: {firstNumber}");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine($"A large number is: {secondNumber}");
}
else
{
    Console.WriteLine($"The numbers are equal to each other: {firstNumber}");
}