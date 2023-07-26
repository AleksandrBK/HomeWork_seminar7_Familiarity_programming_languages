
// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = GetMatrix(rows, columns, 0, 10);

PrintMatrix(result, 0);

GetNumber(result);

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
            Console.Write(formattedNumber.PadRight(4));
        }
        Console.WriteLine();
    }
}

void GetNumber(int[,] matrix)
{
    int getNumber = result[0, 0];

    Console.Write("Введите номер строки: ");
    int userRow = Convert.ToInt32(Console.ReadLine()) - 1;

    Console.Write("Введите номер столбца: ");
    int userColumn = Convert.ToInt32(Console.ReadLine()) - 1;

    if (userRow > matrix.GetLength(0) - 1 || userColumn > matrix.GetLength(1) - 1)
    {
        Console.Write($"Элемента с индексом [{userRow},{userColumn}] в массиве нет");
    }
    else
    {
        Console.Write($"Элемент с индексом [{userRow},{userColumn}] => {result[userRow, userColumn]}");
    }
}
