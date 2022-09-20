// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Пожалуйста, введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

int CalculateSum(int n, int m)
{
    int sum = n;

    if(n < m)
    {
        n++;
        sum += CalculateSum(n, m);
    }

    return sum;

}

int sum = CalculateSum(n, m);

Console.WriteLine($"Сумма натуральных элементов от {n} до {m} равна {sum}");