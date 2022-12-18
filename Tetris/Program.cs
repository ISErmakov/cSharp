/*Игра в тетрис*/

//Вывод экрана
void PrintScreen(int[,] screen)
{
    Console.Clear();
for (int i = 0; i < screen.GetLength(0)-1; i++)
    {
        for (int j = 0; j < screen.GetLength(1); j++)
        {
            Console.Write(screen[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

//Новая фигура сверху
(int[,], int, int) NewFigure(int[,] array)
{
    Random rnd = new Random();
    int y = rnd.Next(0,array.GetLength(1));
    int x = 0;
    array[x, y] = 1;
    PrintScreen(array);
    return (array, x, y);
}

//шаг влево
(int, int) TurnLeft(int[,] array, int x, int y)
{
    array[x, y] = 0;
    array[x, y - 1] = 1;
    PrintScreen(array);
    return (x, y - 1);
}

//шаг вправо
(int, int) TurnRight(int[,] array, int x, int y)
{
    array[x, y] = 0;
    array[x, y + 1] = 1;
    PrintScreen(array);
    return (x, y + 1);
}

//шаг вниз
(int, int) TurnDown(int[,] array, int x, int y)
{
    array[x, y] = 0;
    array[x + 1, y] = 1;
    PrintScreen(array);
    return (x + 1, y);
}

//Проверка на полную строку
bool IsFull(int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[array.GetLength(0)-2,j] == 0) return false;
    }
    for (int i = array.GetLength(0)-1; i > 1; i--)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j];
        }
    }
    return true;
}

Console.Clear();

//Инициализация экрана тетриса. Посленняя строка заполняется 1 - нижняя граница.
int[,] screen = new int[14,10];
int x, y = 0; //координаты фигуры
ConsoleKeyInfo key;
for (int j = 0; j < screen.GetLength(1); j++)
{
    screen[screen.GetLength(0) - 1, j] = 1;
}

//Начинаем игру
(screen, x, y) = NewFigure(screen);

do
{
    key = Console.ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.LeftArrow  : (x, y) = TurnLeft(screen, x, y);
        case ConsoleKey.RightArrow : (x, y) = TurnRight(screen, x, y);
        case ConsoleKey.DownArrow  : (x, y) = TurnDown(screen, x, y);
    }  
    if (screen[x + 1, y] == 1)
        {
            if (IsFull(screen));
            (screen, x, y) = NewFigure(screen);
        }
} while (key.Key != ConsoleKey.Escape);