// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] result = GetMatrix(rows, columns, min, max);

PrintMatrix(result, 0);

double[] columnAverages = CheckMatrix(result);

Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < columns; j++)
{
    Console.Write($"{Math.Round(columnAverages[j], 1)}; ");
}

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, int decimalPlaces)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string formattedNumber = matrix[i, j].ToString($"F{decimalPlaces}");
            Console.Write(formattedNumber.PadRight(5));
        }
        Console.WriteLine();
    }
}


double[] CheckMatrix(int[,] matrix)
{
    double[] columnAverages = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double arithmeticMeanColunm = 0;
        int sumColumnElements = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumColumnElements = sumColumnElements + matrix[i, j];
        }
        arithmeticMeanColunm = (double)sumColumnElements / matrix.GetLength(0);

        columnAverages[j] = arithmeticMeanColunm;
    }

    return columnAverages;
}