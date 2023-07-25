// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] result = GetMatrix(rows, columns, 0.0, 10.0);

PrintMatrix(result, 1);

double[,] GetMatrix(int m, int n, double min, double max) 
{
    double[,] matrix = new double[m, n]; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {     
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round (new Random().NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix, int decimalPlaces) // хочу чтобы массив выглядел красиво
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string formattedNumber = matrix[i, j].ToString($"F{decimalPlaces}");
            Console.Write(formattedNumber.PadRight(6)); 
        }
        Console.WriteLine();
    }
}
