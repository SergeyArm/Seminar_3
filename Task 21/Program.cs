// Напишите программу,которая принимает на вход координаты двух точех и находит расстояние между ними в 2D пространстве
// Например:
// A(3,6); B(2,1) -> 5,09

Console.WriteLine("Введите координаты точки A: координата x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A: координата y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: координата y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
double q = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
Console.WriteLine(Math.Round(q, 2));