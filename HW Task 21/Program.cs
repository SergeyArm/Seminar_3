// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.


Console.WriteLine("Введите координаты точки A: координата Ax: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A: координата Ay: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A: координата Az: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: координата Вх");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: координата Вy: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: координата Вz: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double q = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));   // Вычисление длины
Console.WriteLine(Math.Round(q, 2));                                                        // Округление