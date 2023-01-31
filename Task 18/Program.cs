// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти: ");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x > 4 || x < 1)
// {
//     Console.WriteLine("Такой четверти не существует");
// }
// else
// {
//     if (x == 1)
//     {
//         Console.WriteLine("1 четверть. x>0, y>0");
//     }
//     if (x == 2)
//     {
//         Console.WriteLine("2 четверть. x<0, y>0");
//     }
//     if (x == 3)
//     {
//         Console.WriteLine("3 четверть. x<0, y<0");
//     }
//     if (x == 4)
//     {
//         Console.WriteLine("4 четверть. x>0, y<0");
//     }
// }

string[] quartrs = {"x>0, y>0",
                    "x<0, y>0",
                    "x<0, y<0",
                    "x>0, y<0"};

Console.WriteLine("Введите цифру плоскости координат: ");
int q =Convert.ToInt32(Console.ReadLine());
if(q>=1 && q<=4)
{
    Console.WriteLine(quartrs[q-1]);
}                    
else
{
    Console.WriteLine("Неверный ввод");
}

// Можно решить задачу методом Switch case!