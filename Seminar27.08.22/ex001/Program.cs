
int m = 3;
int n = 5;

int[,] matrix = new int[m, n];

for (int row = 0; row < m; row++)
{
    for (int column = 0; column < n; column++)
    {
        matrix[row,column] = new Random().Next(1, 10);
        Console.Write($"{matrix[row, column],3}");
    }
    Console.WriteLine();
}