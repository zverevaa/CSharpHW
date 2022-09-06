// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] nums = new int[10];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write(array[i] + " ");
    }
}

// int FindMin(int[] array)
// {
//     int min = array[0];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < min)
//         {
//             min = array[i];
//         }
//         else
//         {
//             continue;
//         }
//     }
//     return min;
// }

// int FindMax(int[] array)
// {
//     int max = array[0];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > max)
//         {
//             max = array[i];
//         }
//         else
//         {
//             continue;
//         }
//     }
//     return max;
// }

int FindDiff(int[] array)
{
    int max = array[0];
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        else if(array[i] > max)
        {
            max = array[i];
        }
        else
        {
            continue;
        }
    }
    Console.WriteLine(max);
    Console.WriteLine(min);
    return max - min;
}
FillArray(nums);
Console.WriteLine(FindDiff(nums));
