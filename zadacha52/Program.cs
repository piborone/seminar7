// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int InputNumbers(string str) //проверка введенного числа в размер массива
{
    int numbers;
    string? text;
    while(true)
    {
    Console.Write(str);
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

void PrintMatrix(int[,] matr) // Вывод массива
{
System.Console.WriteLine("Исходный массив");
for(int i = 0; i < matr.GetLength(0); i++)
{
    for(int j = 0; j < matr.GetLength(1); j++)
    {
    System.Console.Write(matr[i,j] + $"\t");
    }
    System.Console.WriteLine();
}
}

int[,] FillMatrix(int rows, int cols) // рандомное заполнение массива
{
Random rand = new Random();
int[,] array2d = new int[rows, cols];
for(int i = 0; i < rows; i++ )
{
    for(int j = 0; j < cols; j++)
    {
    array2d[i, j] = rand.Next(0, 11);
    }
}
return array2d;
}

void Avg(int[,] array)
{

System.Console.WriteLine("Среднее арифметическое каждого столбца: ");  
for(int j = 0; j < array.GetLength(1); j++)
{
    double avg = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
    avg+=array[i,j];
    
    }
    System.Console.Write(Math.Round((avg/array.GetLength(0)),2)+"  ");
}
}

int rows = InputNumbers("Введите число M: ");
int cols = InputNumbers("Введите число N: ");
System.Console.WriteLine();
int[,] array2d = FillMatrix(rows, cols);
PrintMatrix(array2d);
Avg(array2d);

