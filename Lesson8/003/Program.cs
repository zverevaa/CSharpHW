// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstMatrix = {{2, 4}, {3, 2}};
int[,] secondMatrix = {{3, 4}, {3, 3}};


void MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        Console.WriteLine("Эти матрицы нельзя умножить.");
    }
    else
    {
        int[,] result = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                int temp = 0;
                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    temp += firstMatrix[i, k] * secondMatrix[k, j];
                }
                result[i, j] = temp;
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

MultiplyMatrices(firstMatrix, secondMatrix);