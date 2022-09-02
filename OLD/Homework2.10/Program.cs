namespace Homework2._10;
class Program
{
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

    static int InputNumber()
    {
        System.Console.Write("Введите трехзначное число: ");
        return int.Parse(System.Console.ReadLine());
    }
    static int ShowSecondDigit(int number)
    {
        return (number / 10) % 10;
    }
    static void Main(string[] args)
    {
        int number = InputNumber();
        System.Console.WriteLine($"Число: {number} \nВторая цифра: {ShowSecondDigit(number)}");
    }
}