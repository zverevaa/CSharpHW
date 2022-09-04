using System.Collections.ObjectModel;
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] nums = new int[8];

void FillArray(int[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine();
}

FillArray(nums);
PrintArray(nums);
