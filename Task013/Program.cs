/*
Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Please, enter the number");
int number = Convert.ToInt32(Console.ReadLine());
int NextNumber = Math.Abs(number);

if (NextNumber >= 100)
{
    while (NextNumber >= 1000) NextNumber /= 10;
    int thirdDigit = NextNumber % 10;
    Console.WriteLine(thirdDigit);
}
else 
    Console.WriteLine("The third digit does not exist");