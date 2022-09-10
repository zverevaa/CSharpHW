// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Пожалуйста, введите значения для двух прямых.");
Console.Write("Значение b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение k2:");
int k2 = Convert.ToInt32(Console.ReadLine());

void GetCrossPoint(int b1, int k1, int b2, int k2)
{
    // double x = (b1 - b2) / (k2 - k1);
    double x = ((double)(b1 - b2) / (k2 - k1));
    double y = k1 * x + b1;

    Console.WriteLine($"Прямые пересекаются в точке с координатами x:{x}, y:{y}");
}  

GetCrossPoint(b1, k1, b2, k2);