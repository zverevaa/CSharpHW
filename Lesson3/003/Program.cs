﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Пожалуйста, введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= num; i++)
{
    if(i == num)
    {
        Console.Write(Math.Pow(i, 3));
    }
    else
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
}

