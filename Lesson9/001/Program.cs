// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Пожалуйста, введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());


if (m < n)
{
    int[] includedNumbers = new int[n - m + 1];
    int count = includedNumbers.Length;

    for (int i = n; i >= m; i--)
    {
        includedNumbers[count - 1] = PrintNumbers(m, i);
        count--;
    }
    Console.WriteLine(string.Join(", ", includedNumbers));
}
else
{
    Console.WriteLine("Первое число должно быть меньше второго, попробуйте еще раз");
}


int PrintNumbers(int m, int n)
{
    int num = n;
    if (m - 1 < n)
    {
        n--;
        PrintNumbers(m, n);
    }
    return num;
}