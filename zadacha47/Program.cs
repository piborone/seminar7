// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int InputNumbers(string str)
{
    int numbers;
    string text;
    while(true)
    {
        Console.WriteLine(str);
        text = Console.ReadLine();
        if(int.TryParse(text, out numbers))
        {
            while(numbers < 1)
            {
            System.Console.WriteLine("Размер массива не может иметь отрицательное или нулевое значение");
            System.Console.WriteLine("Введите число повторно: ");
            numbers = Convert.ToInt32(Console.ReadLine());
            }
            break;
        }
        else
        {
        Console.WriteLine("Ошибка!!! Введено не верное значение!");
        }
    }
    return numbers;
}

void PrintMatrix(double[,] matr) // Вывод массива
{
for(int i = 0; i < matr.GetLength(0); i++)
{
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        System.Console.Write(Math.Round(matr[i,j],2) + $"\t"); // округление переменных до 2х знаков после запятой
    }
    System.Console.WriteLine();
}
}

double[,] FillMatrix(int rows, int cols) // рандомное заполнение массива
{
    Random rand = new Random();
    double[,] array2d = new double[rows, cols];
    for(int i = 0; i < rows; i++ )
    {
        for(int j = 0; j < cols; j++)
        {
       array2d[i, j] = rand.Next(-10, 11)+rand.NextDouble(); // вещественные числа
        }
    }

return array2d;
}

int rows = InputNumbers("Введите число M: ");
int cols = InputNumbers("Введите число N: ");
System.Console.WriteLine();
double[,] array2d = FillMatrix(rows, cols);
PrintMatrix(array2d);
