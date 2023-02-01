
Random rnd = new Random();
int k = rnd.Next(1,10);
string[] strings = new string[k];

for (int i = 0; i < k; i++)
{
    strings[i] = Console.ReadLine();
}

string[] result = new string[k];
k = 0;

for (int i = 0; i < strings.GetLength(0); i++)
{
    if (strings[i].Length <= 3)
        {
            k++;
            result[k] = strings[i];
        }
}

foreach (var item in result)
{
    Console.WriteLine(item);
}