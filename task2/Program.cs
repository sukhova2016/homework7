Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 20);
        Console.Write("{0,4}", array[i, j]);
    }
    Console.WriteLine();
}


Console.Write("Введите строку элемента массива для поиска:");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента массива для поиска:");
int pos2 = Convert.ToInt32(Console.ReadLine());

if (pos1 < 0 | pos1 > m-1  | pos2 < 0 | pos2 > n-1 )
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", array[pos1, pos2]);
}
Console.ReadLine();
