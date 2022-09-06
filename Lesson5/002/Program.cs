// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] nums = new int[10];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write(array[i] + " ");
    }
}

int AddUneven(int[] array)
{
    int sum = 0;
    int i = 1;
    while(i < array.Length)
    {
        sum += array[i];
        i += 2;
    }

    return sum;
}
FillArray(nums);
Console.WriteLine(AddUneven(nums));

