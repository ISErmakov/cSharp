/*
Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Please, enter the number");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) >= 100)
{
    int thirdDigit = (Math.Abs(number) / 100) % 10;
    Console.WriteLine(thirdDigit);
}
else 
    Console.WriteLine("The third digit does not exist");