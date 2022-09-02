// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

namespace Homework2._1;
class Program
{
    static int GetNumber()
    {
        System.Console.Write("Введите число кратное 7 и 23: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    static void Main(string[] args)
    {
        int number = GetNumber();
        if (number % 7 == 0 && number % 23 == 0) System.Console.WriteLine($"число {number} кратно 7 и 23");
        //else System.Console.WriteLine($"число {number} кратно 7 и 23");
    }
}
