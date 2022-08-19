Console.Write("Пожалуйста, введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите третье число: ");
int c = int.Parse(Console.ReadLine());

if (a > b & a > c) 
{
    Console.WriteLine(a + " самое большое число из введенных");
} 
else if (b > a & b > c)
{
    Console.WriteLine(b + " самое большое число из введенных");
}
else
{
    Console.WriteLine(c + " самое большое число из введенных");
}