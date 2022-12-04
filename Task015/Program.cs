/*
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Please, enter the number day of week");
int numberTheDayOfWeek = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(isWeekend(numberTheDayOfWeek));

string isWeekend(int x)
{
    switch (x)
    {
        case 1:
            return "No, Monday is not a weekend";
            break;
        case 2:
            return "No, Tuesday is not a weekend";
            break;
        case 3:
            return "No, Wednesday is not weekend";
            break;
        case 4:
            return "No, Thursday is not weekend";
            break;
        case 5:
            return "No, Friday is not weekend";
            break;
        case 6:
            return "Yes, Saturday is weekend";
            break;
        case 7:
            return "Yes, Sunday is weekend";
            break;
        default:
            return "The day of week with this number does not exist";
            break;
    }
}