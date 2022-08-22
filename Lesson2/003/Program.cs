int weekday = new Random().Next(1, 8);

if (weekday == 6 || weekday == 7)
{
    Console.WriteLine("Сегодня выходной");
}
else
{
    Console.WriteLine("Сегодня будний день");
}

Console.WriteLine(weekday);