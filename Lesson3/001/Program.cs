// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
int isNumericHelper = 0;
bool isNumeric = int.TryParse(num, out isNumericHelper);


if(num.Length == 5 && isNumeric)
{
    if(num[0] == num[4] && num[1] == num[3]) 
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введенные Вами данные не являются числом, или число не является пятизначным. Попробуйте еще раз");
}
