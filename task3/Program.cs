Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

Random random = new Random();
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 20);
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }

    double sum = 0;
    Console.Write($"Среднее арифметическое каждого столбца:  ");

    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            sum += array[i, j];       
        }   
        Console.Write("{0,6:F1}", (sum / m));
    }

}


