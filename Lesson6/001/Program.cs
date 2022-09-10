// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел Вы будете вводить?");
int arrSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Пожалуйста, введите {arrSize} чисел");
int[] nums = new int[arrSize];

for (int i = 0; i < arrSize; i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
        else
        {
            continue;
        }
    }
    return (count);
}

Console.WriteLine($"Количество чисел больше 0: {CountPositive(nums)}");