// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] matrix = {{1, 4 ,7, 2}, {5, 9, 2, 3}, {8, 4, 2 ,4}};

Console.Write("Пожалуйста, введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

void FindNumber(int[,] matrix, int row, int column)
{
    if(row >= matrix.GetLength(0) ||
       column >= matrix.GetLength(1) ||
       row < 0 ||
       column < 0)
    {
        Console.WriteLine("Такого числа нет в данном массиве");
    }
    else
    {
        Console.WriteLine($"Число на данной позиции: {matrix[row, column]}");
    }
}

FindNumber(matrix, row, column);