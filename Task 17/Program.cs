// Напишите программу, которая принимает на вход координаты точки(X, Y),
// причем X не равно  0 и Y не равно 0
// и выдает номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 & y > 0)
{
    Console.WriteLine("1 четверть.");
}
else
{
if (x < 0 & y > 0)
    {
        Console.WriteLine("2 четверть.");
    }
    else
    {
        if (x < 0 & y < 0)
        {
            Console.WriteLine("3 четверть.");
        }
        else
        {
            Console.WriteLine("4 четверть.");
        }
    }
};

