// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] matrix = new int[2, 2, 2];
int[] numbers = new int[matrix.GetLength(0)
                      * matrix.GetLength(1)
                      * matrix.GetLength(2)];

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}

int[] RandomizeNumbers(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (array[i] == array[j])
            {
                array[i] = new Random().Next(10, 100);
                i -= 1;
            }
        }
    }
    return array;
}

void FillMatrix(int[,,] matrix, int[] array)
{
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = array[index];
                index += 1;
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

FillArray(numbers);
RandomizeNumbers(numbers);
FillMatrix(matrix, numbers);

