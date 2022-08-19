Console.Write("Пожалуйста, введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(a + " больше, чем " + b);
}
else if (a == b)
{
    Console.WriteLine("Введенные числа равны");
}
else
{
    Console.WriteLine(b + " больше, чем " + a);
}

