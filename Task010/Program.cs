/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Please, enter the number");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) >= 10)
{
    int secondDigit = (Math.Abs(number) / 10) % 10;
    Console.WriteLine(secondDigit);
}
else 
    Console.WriteLine("The second digit does not exist");