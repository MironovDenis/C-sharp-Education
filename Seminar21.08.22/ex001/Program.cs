//Показать двумерный массив размером m×n заполненный целыми числами

int[,] Fill(int n, int m)
{
    int[,] table = new int[n, m];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 25);
        }
    }
    return table;
}

int[,] Print(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + " ");
        }
        Console.WriteLine();
    }


    return table;
}

Fill(5, 4);
Print(Fill(5, 4));

