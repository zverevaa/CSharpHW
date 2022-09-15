// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = {{1, 4 ,7, 2}, {5, 9, 2, 3}, {8, 4, 2 ,4}};

string FindColumnMean(int[,] matrix)
{
    double sum = 0;
    string[] columnMean = new string[matrix.GetLength(1)];

    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        columnMean[i] = Convert.ToString(Math.Round(sum / matrix.GetLength(0), 2));
        // columnMean[i] = String.Format("{0:0.0}", sum / matrix.GetLength(0));
        sum = 0;
    }
    return string.Join(", ",columnMean);
}

Console.WriteLine(FindColumnMean(matrix));