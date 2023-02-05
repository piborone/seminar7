// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
Random rand = new Random();
double[,] array2d = new double[m, n];
for(int i = 0; i < m; i++ )
{
    for(int j = 0; j < n; j++)
    {
       array2d[i, j] = rand.Next(-10, 11)+rand.NextDouble();
    }
    
}
for(int i = 0; i < array2d.GetLength(0); i++)
{
    for(int j = 0; j < array2d.GetLength(1); j++)
    {
        System.Console.Write(Math.Round(array2d[i,j],2) + $"\t");
    }
    System.Console.WriteLine();
}