int num = new Random().Next(1, 150);

int num1 = num % 10;

if (num / 100 == 0)
{
    Console.WriteLine($"В числе {num} нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра числа {num} - {num1}");
}
