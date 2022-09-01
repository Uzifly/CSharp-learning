// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

namespace Homework3._23;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите N");
        int n = Convert.ToInt32(System.Console.ReadLine());
        for (int i = 1; i < n+1; i++)
            System.Console.WriteLine(Math.Pow(i, 3));
    }
}
