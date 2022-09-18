using System;
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = new int[4, 4];

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillMatrix(matrix);

int FindLowestSum(int[,] matrix)
{
    int sum = 0;
    int[] rowSums = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        rowSums[i] = sum;
        sum = 0;
    }

    int min = rowSums[0];
    int minIndex = 0;

    Console.WriteLine();
    Console.WriteLine(String.Join(" ", rowSums));
    Console.WriteLine();

    for (int k = 1; k < rowSums.Length; k++)
    {
        if (rowSums[k] < min)
        {
            min = rowSums[k];
            minIndex = k;
        }
    }
    return minIndex;
}

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindLowestSum(matrix) + 1}");