// Напишите программу, которая принимает число(N) и выдает таблицу квадратов чисел от 1 до N.
// Например:
// 5 -> 1, 4, 9, 16, 25.

// Способ 1
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= a)
{
Console.Write(Math.Pow(count, 2)+" ");
count++;
}

// Способ 2
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// for(int count = 1; count <= a; count++)
// {
//     Console.Write(Math.Pow(count, 2)+ " ");
// }
// Console.WriteLine();