/*Игра в тетрис*/

// TODO экран тетриса окружен 1 по периметру, движение фигуры вправо влево вниз.
// Пробуем передвинуть подматрицу на экране. (методы впарво влево вниз, поворот) 
// (метод проверки) Если нет противоречий(пересечений) с границей и двугими элементами, то значит двигать можно, иначе нельзя.
// Если нельзя двинуться вниз, то вводим новую фигуру (метод новая фигура).
// Объект фигура 5 штук линия квадрат буква г зиг заг и три лучник
//  ****   **    *      *    **
//         **    ***   ***    **
//  - у каждой фигуры 4 варианта разворота. (у линии - 2 у квадрата - 1)
// Проверка перед вводом новой фигуры. Если не проходит - конец игры.
// Перед новой фигурой - Если собрана строка - то экран вниз сдвинуть (функция сдвинуть). 

// Вывод экрана.
void PrintScreen(int[,] screen)
{
    //Console.Clear();
    for (int i = 0; i < screen.GetLength(0); i++)
        {
            for (int j = 0; j < screen.GetLength(1); j++)
            {
                if (screen[i,j] == 0) Console.Write("  ");
                else Console.Write(screen[i,j]+ " ");
            }
            Console.WriteLine();
    }
}
/*
// Новая фигура сверху.
(int[,], int, int) NewFigure(int[,] array)
{
    Random rnd = new Random();
    int y = rnd.Next(0,array.GetLength(1));
    int x = 0;
    array[x, y] = 1;
    PrintScreen(array);
    return (array, x, y);
}
*/

 int[,,] f = new int[8,4,4];
    // *
    // * * *
    f[0, 0, 0] = 1; f[0, 1, 0] = 1; f[0, 1, 1] = 1; f[0, 1, 2] = 1;
    // * *
    // *
    // *
    f[1, 0, 0] = 1; f[1, 0, 1] = 1; f[1, 1, 0] = 1; f[1, 2, 0] = 1;
    // * * *
    //     *
    f[2, 0, 0] = 1; f[2, 0, 1] = 1; f[2, 0, 2] = 1; f[2, 1, 2] = 1;
    //   *
    //   *
    // * *
    f[3, 0, 1] = 1; f[3, 1, 1] = 1; f[3, 2, 0] = 1; f[3, 2, 1] = 1;
    // * *
    // * *
    f[4, 0, 0] = 1; f[4, 0, 1] = 1; f[4, 1, 0] = 1; f[4, 1, 1] = 1;
    f[5, 0, 0] = 1; f[5, 0, 1] = 1; f[5, 1, 0] = 1; f[5, 1, 1] = 1;
    f[6, 0, 0] = 1; f[6, 0, 1] = 1; f[6, 1, 0] = 1; f[6, 1, 1] = 1;
    f[7, 0, 0] = 1; f[7, 0, 1] = 1; f[7, 1, 0] = 1; f[7, 1, 1] = 1;


(int[,], int, int, int) NewFigure1(int[,] array)
{
    int x = 0;
    int y = array.GetLength(1) / 2;

    Random rnd = new Random();
    int fig = rnd.Next(0,8);

    //TODO проверка на печать без сдвига. Если невозможна - то конец игры, иначе делаем экран с новой фигурой.
    for (int i = 0; i < f.GetLength(1); i++)
    {
        for (int j = 0; j < f.GetLength(2); j++)
        {
            array[x+i,y+j] = f[fig,i,j];
        }
    }
    PrintScreen(array);
    return(array, x, y, fig+1); //TODO убрать fig+1
}

bool CanTurn(int[,] array, int x, int y, int fig, int turn) //Добавить вниз поворот
{
    int[,] arrayTemp = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayTemp[i,j] = array[i,j];
        }
    }

// Влево
    if (turn == 1)
    {
        for (int i = 0; i < f.GetLength(1); i++)
        {
            for (int j = 0; j < f.GetLength(2); j++)      
            {
                arrayTemp[x+i,y+j] -= f[fig,i,j];
                arrayTemp[x+i,y+j-1] += f[fig,i,j];
                if (arrayTemp[x+i,y+j-1] == 2) return false;
            }
        }
    }

// Вправо
    if (turn == 2)
    {
        for (int i = 0; i < f.GetLength(1); i++)
        {
            for (int j = 0; j < f.GetLength(2); j++)      
            {
                arrayTemp[x+i,y+j] -= f[fig,i,j];
                arrayTemp[x+i,y+j+1] += f[fig,i,j];
                Console.Write(arrayTemp[x+i,y+j]); //ТУТ ГДЕ ТО ОШИБКА НУЖНА БУМАЖКА
                //if (arrayTemp[x+i,y+j+1] == 2) return false;
            }
            Console.WriteLine();
        }
    }
    return true;
}

// Шаг влево.
(int, int) TurnLeft(int[,] array, int x, int y, int fig)
{
    if (CanTurn(array, x, y, fig - 1, 1))
    {
        for (int i = 0; i < f.GetLength(1); i++)
        {
            for (int j = 0; j < f.GetLength(2); j++)      
            {
                array[x+i,y+j] -= f[fig-1,i,j];
                array[x+i,y+j-1] += f[fig-1,i,j];
            }
        }
        PrintScreen(array);
        return(x, y-1);
    }
    else return(x,y);
/*
    switch (fig)
    {
        case 1:
            if (array[x, y-1] == 1 || array[x+1, y-1] == 1) return (x,y);
            array[x, y] = 0;                                            //      *
            array[x+1, y] = 0; array[x+1,y+1] = 0; array[x+1,y+2] = 0;  //      * * *
            array[x, y-1] = 1;
            array[x+1, y-1] = 1; array[x+1,y] = 1; array[x+1,y+1] = 1;
            PrintScreen(array);
            return (x, y - 1);
        case 2:
            if (array[x, y-1] == 1 || array[x+1, y-1] == 1 || array[x+2, y-1] == 1) return (x,y);
            array[x, y] = 0; array[x, y+1] = 0;                         //      * *
            array[x+1,y] = 0;                                           //      *
            array[x+2,y] = 0;                                           //      *
            array[x, y-1] = 1; array[x, y] = 1;
            array[x+1,y-1] = 1; 
            array[x+2,y-1] = 1;
            PrintScreen(array);
            return (x, y - 1);
        case 3:
            if (array[x, y-1] == 1 || array[x+1, y+1] == 1) return (x,y);
            array[x, y] = 0; array[x, y+1] = 0; array[x,y+2] = 0;       //      * * *
                                                array[x+1,y+2] = 0;     //          *
            array[x, y-1] = 1; array[x, y] = 1; array[x,y+1] = 1; 
                                                array[x+1,y+1] = 1;
            PrintScreen(array);
            return (x, y - 1);
        case 4:
            if (array[x, y] == 1 || array[x+1, y] == 1 || array[x+2, y-1] == 1) return (x,y);
                              array[x, y+1] = 0;                        //          *
                              array[x+1, y+1] = 0;                      //          *  
            array[x+2,y] = 0; array[x+2,y+1] = 0;                       //        * *
                              array[x, y] = 1; 
                              array[x+1, y] = 1; 
            array[x+2,y-1] = 1; array[x+2,y] = 1;
            PrintScreen(array);
            return (x, y - 1);
        default:
            return(x,y);
    }
    */
    
}

// Шаг вправо.
(int, int) TurnRight(int[,] array, int x, int y, int fig)
{
    if (CanTurn(array, x, y, fig - 1, 2))
    {
        for (int i = 0; i < f.GetLength(1); i++)
        {
            for (int j = 0; j < f.GetLength(2); j++)      
            {
                //array[x+i,y+j] -= f[fig - 1,i,j];
                //array[x+i,y+j+1] += f[fig-1,i,j];
            }
        }
        PrintScreen(array);
        return(x, y);
    }
    else return(x,y);

    /*
    switch (fig)
    {
        case 1:
            if (array[x, y+1] == 1 || array[x+1, y+3] == 1) return (x,y);
            array[x, y] = 0;                                                    //      *
            array[x+1, y] = 0; array[x+1,y+1] = 0; array[x+1,y+2] = 0;          //      * * *
            array[x, y+1] = 1; 
            array[x+1, y+1] = 1; array[x+1,y+2] = 1; array[x+1,y+3] = 1;
            PrintScreen(array);
            return (x, y + 1);
        case 2:
            if (array[x, y+2] == 1 || array[x+1, y+1] == 1 || array[x+2, y+1] == 1) return (x,y);
            array[x, y] = 0; array[x, y+1] = 0;                                 //      * *
            array[x+1,y] = 0;                                                   //        *
            array[x+2,y] = 0;                                                   //        *
            array[x, y+1] = 1; array[x, y+2] = 1; 
            array[x+1,y+1] = 1; 
            array[x+2,y+1] = 1;
            PrintScreen(array);
            return (x, y + 1);
        case 3:
            if (array[x, y+3] == 1 || array[x+1, y+3] == 1) return (x,y);
            array[x, y] = 0; array[x, y+1] = 0; array[x,y+2] = 0;          //   * * * 
                                                array[x+1,y+2] = 0;        //       *
            array[x, y+1] = 1; array[x, y+2] = 1; array[x,y+3] = 1; 
                                                array[x+1,y+3] = 1;
            PrintScreen(array);
            return (x, y + 1);
        case 4:
            if (array[x, y+2] == 1 || array[x+1, y+2] == 1 || array[x+2, y+2] == 1) return (x,y);
                              array[x, y+1] = 0;           //      *
                              array[x+1, y+1] = 0;         //      *
            array[x+2,y] = 0; array[x+2,y+1] = 0;          //    * *          
                                array[x, y+2] = 1; 
                                array[x+1, y+2] = 1; 
            array[x+2,y+1] = 1; array[x+2,y+2] = 1;
            PrintScreen(array);
            return (x, y + 1);
        default:
            return(x,y);
    }
    */
}

// Шаг вниз.
(int, int, bool) TurnDown(int[,] array, int x, int y, int fig)
{    
    switch (fig)
    {
        case 1:
            if (array[x+2, y] == 1 || array[x+2, y+1] == 1 || array[x+2, y+2] == 1) return (x,y,true);
            array[x, y] = 0;                                                //  *
            array[x+1, y] = 0; array[x+1,y+1] = 0; array[x+1,y+2] = 0;      //  * * *
            array[x+1, y] = 1; 
            array[x+2, y] = 1; array[x+2,y+1] = 1; array[x+2,y+2] = 1;
            PrintScreen(array);
            return (x + 1, y, false);
        case 2:
            if (array[x+1, y+1] == 1 || array[x+3, y] == 1) return (x,y,true);
            array[x, y] = 0; array[x, y+1] = 0;     //      * *
            array[x+1,y] = 0;                       //      *
            array[x+2,y] = 0;                       //      *
            array[x+1, y] = 1; array[x+1, y+1] = 1;
            array[x+2,y] = 1;
            array[x+3,y] = 1;
            PrintScreen(array);
            return (x + 1, y, false);
        case 3:
            if (array[x+1, y] == 1 || array[x+1, y+1] == 1|| array[x+2, y+2] == 1) return (x,y,true);
            array[x, y] = 0; array[x, y+1] = 0; array[x,y+2] = 0;       //      * * *
                                                array[x+1,y+2] = 0;     //          *
            array[x+1, y] = 1; array[x+1, y+1] = 1; array[x+1,y+2] = 1;
                                                    array[x+2,y+2] = 1;
            PrintScreen(array);
            return (x + 1, y, false);
        case 4:
            if (array[x+3, y] == 1 || array[x+3, y+1] == 1) return (x,y,true);
                              array[x, y+1] = 0;        //        *
                              array[x+1, y+1] = 0;      //        *
            array[x+2,y] = 0; array[x+2,y+1] = 0;       //      * *
                              array[x+1, y+1] = 1; 
                              array[x+2, y+1] = 1; 
            array[x+3,y] = 1; array[x+3,y+1] = 1;
            PrintScreen(array);
            return (x + 1, y, false);
        default:
            return (x,y,true);
    }
}

(int, int, int) TurnRound(int[,] array, int x, int y, int fig)
{
    switch (fig)
    {
        case 1:
            //Если при повороте конфликт, то поворачивать нельзя
            if (array[x+2,y] == 1 || array[x+2,y] == 1) return (x,y,fig); 
            array[x,y+1] = 1;
            array[x+1,y+1] = 0;
            array[x+1,y+2] = 0;
            array[x+2,y] = 1;
            PrintScreen(array);
            return (x, y, fig+1);
        case 2:
            if (array[x,y+2] == 1 || array[x+1,y+2] == 1) return (x,y,fig);
            array[x,y+2] = 1;
            array[x+1,y] = 0;
            array[x+1,y+2] = 1;
            array[x+2,y] = 0;
            PrintScreen(array);
            return (x, y, fig+1);
        case 3:
            if (array[x+1,y+1] == 1 || array[x+2,y] == 1 || array[x+2,y+1] == 1) return (x,y,fig);
            array[x,y] = 0; array [x,y+2] = 0;
            array[x+1,y+1] = 1; array[x+1, y+2] = 0;
            array[x+2,y] = 1; array[x+2,y+1] = 1;
            PrintScreen(array);
            return (x, y, fig+1);
        case 4:
            if (array[x,y] == 1 || array[x+1,y] == 1 || array[x+1,y+2] == 1) return (x,y,fig);
            array[x,y] = 1; array [x,y+1] = 0;
            array[x+1,y] = 1; array[x+1,y+2] = 1;
            array[x+2,y] = 0; array[x+2,y+1] = 0;
            PrintScreen(array);
            return (x, y, 1);
        default:
            return (x,y,fig);
    }
    
}

// Проверка на полную строку.
void IsFull(int [,] array)
{
    for (int i = 0; i < array.GetLength(0)-1; i++) // Перебираем все кроме последней строки
    {
        bool flag = true;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == 0) flag = false;  // Если в строке встречается 0, что она не полная
        }
        if (flag)   // Если нашли полную строку переписываем все элементы выше этой строки со сдвигом вниз
        {
            for (int k = i; k > 1; k--)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[k, j] = array[k - 1, j];
                }
            }
        }
    }
}

Console.Clear();

// Инициализация экрана тетриса.
int[,] screen = new int[14,13];
int x, y = 0; // Координаты фигуры (верхняя левая точка)
int fig = 1; // Фигура номер 1 
bool flag;

/*
void TimerCallback(Object o) //TODO обнулять таймер после нажатия кнопки
   {
      flag = false;
      //Console.WriteLine("In TimerCallback: " + DateTime.Now);
      (x, y, flag) = TurnDown(screen, x, y, fig);
      if (flag)
      {
            IsFull(screen);
            (screen, x, y, fig) = NewFigure1(screen);
      }
   }
*/

//Периметр единицами
for (int j = 0; j < screen.GetLength(1); j++)
{
    screen[screen.GetLength(0) - 1, j] = 1;
    screen[screen.GetLength(0) - 2, j] = 1;
    screen[screen.GetLength(0) - 3, j] = 1;
}

for (int i = 0; i < screen.GetLength(0); i++)
{
    screen[i, 0] = 1;
    screen[i, 1] = 1;
    screen[i, 2] = 1;
    screen[i, screen.GetLength(1) - 1] = 1;
    screen[i, screen.GetLength(1) - 2] = 1;
    screen[i, screen.GetLength(1) - 3] = 1;
}



// Начинаем игру
(screen, x, y, fig) = NewFigure1(screen);

//Timer downTimer = null;
//downTimer = new Timer(TimerCallback, null, 5000, 2000);

ConsoleKeyInfo key;
do
{
    flag = false;
    key = Console.ReadKey();
    //downTimer.Dispose();
    Console.WriteLine(key.Key);
    switch (key.Key)
    {
        case ConsoleKey.Spacebar  : (x, y, fig) = TurnRound(screen, x, y, fig);
        break;
        case ConsoleKey.LeftArrow  : (x, y) = TurnLeft(screen, x, y, fig);
        break;
        case ConsoleKey.RightArrow : (x, y) = TurnRight(screen, x, y, fig);
        break;
        case ConsoleKey.DownArrow  : (x, y, flag) = TurnDown(screen, x, y, fig);
        break;
    }  

    if (flag)
        {
            IsFull(screen);
            (screen, x, y, fig) = NewFigure1(screen);
        }
    //downTimer.Change(0,2000);
} while (key.Key != ConsoleKey.Escape);