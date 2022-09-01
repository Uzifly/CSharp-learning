// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//using Math;

namespace Homework3._19;
class Program
{
    static int GetFiveDigNumber()
    {
        bool NumIsCorrect = false;
        int num = 0;
        while (NumIsCorrect == false)
        {
            System.Console.Write("Введите пятизначное число: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 10000 && num <= 99999)
            {
                NumIsCorrect = true;
                //System.Console.WriteLine($"Число {num} корректно");
            }
            else
            {
                System.Console.WriteLine("Число вне диапазона");
            }
        }
        return num;
    }

    static bool IsPalindrome(int number)
    {
        int revNumber = 0, bufNumber = number;
        while (number != 0)
        {
            revNumber = revNumber * 10 + number % 10;
            number /= 10;
        }
        if (bufNumber == revNumber) return true;
        else return false;
    }
    static void Main(string[] args)
    {
        int number = GetFiveDigNumber();
        bool numbIsPalindrome = IsPalindrome(number);
        if (numbIsPalindrome) System.Console.WriteLine("Число палиндром");
        else System.Console.WriteLine("Число не является палиндромом");
    }
}

