namespace Homework4._27;
class Program
{
    static int GetSumDigit(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Сумма цифр в числе {number} = {GetSumDigit(number)}");
    }
}
