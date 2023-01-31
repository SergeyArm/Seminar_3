// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
// Например:
// 3 -> 1, 8, 27


Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
for(int count = 1; count <= a; count++)
{
    Console.Write(Math.Pow(count, 3)+ " ");
}
Console.WriteLine();