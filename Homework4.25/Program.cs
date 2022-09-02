

namespace Homework4._25;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень");
        int b = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"{a} в степени {b} = {Math.Pow(a,b)}");
    }
}
