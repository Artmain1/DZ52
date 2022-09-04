// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

int m = ReadInt("Введите количество строк: ");
int n = ReadInt("Введите количество столбцов: ");

int[,] matrix = FillMatrix(m, n, 1, 9);
PrintMatrix(matrix);
PrintAverage(matrix);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int[,] FillMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintAverage(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }

        double average = (double)sum / matrix.GetLength(0);
        Console.Write(Math.Round(average, 2) + " ");
    }
    Console.WriteLine();
}