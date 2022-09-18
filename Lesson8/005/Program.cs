// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

string[,] matrix = new string[4, 4];
string[] array = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16" };


string[,] FillMatrix(string[,] matrix, string[] array)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int top = 0;
    int bottom = rows - 1;
    int left = 0;
    int right = columns - 1;
    int direction = 0;
    int index = 0;

    while (top <= bottom && left <= right)
    {
        if (direction == 0)
        {
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = array[index];
                index++;
            }
            top++;
            direction = 1;
        }
        else if (direction == 1)
        {
            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = array[index];
                index++;
            }
            right--;
            direction = 2;
        }
        else if (direction == 2)
        {
            for (int i = right; i >= left; i--)
            {
                matrix[bottom, i] = array[index];
                index++;
            }
            bottom--;
            direction = 3;
        }
        else if (direction == 3)
        {
            for (int i = bottom; i >= top; i--)
            {
                matrix[i, left] = array[index];
                index++;
            }
            left++;
            direction = 0;
        }
    }
    return matrix;
}

void PrintMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillMatrix(matrix, array);
PrintMatrix(matrix);
