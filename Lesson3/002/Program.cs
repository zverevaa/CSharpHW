// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Пожалуйста, введите координату X точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Y точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Z точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите координату X точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.Write(String.Format("Расстояние между координатами равно: {0:0.00}", distance));