namespace Homework2._13;
class Program
{

    // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    // 645 -> 5
    // 78 -> третьей цифры нет
    // 32679 -> 6
    static int GetNumber()
    {
        System.Console.Write("Введите число: ");
        return int.Parse(System.Console.ReadLine());
    }

    static int GetNumOfDigit(int number)
    {
        int i = 0;
        while (number != 0) 
        {
            number /= 10;
            i++;
        }
        return i;
    }

    static int[] GetDigFromNumber(int number, int numLenght)
    {
        int[] arrDig = new int[numLenght];
        for (int i = 0; i < numLenght; i++)
        {
            arrDig[i] = number % 10;
            number /= 10;
        }
        return arrDig;
    }

    static void PrintArrayPos(int[] array, int pos)
    {
        try
        {
            System.Console.WriteLine(array[array.Length-pos]);
        }
        catch (System.IndexOutOfRangeException)
        {
            System.Console.WriteLine("Такого числа нет");
        }
        
    }

    static void Main(string[] args)
    {
        int number = GetNumber();
        int i = GetNumOfDigit(number);
        int[] digit = GetDigFromNumber(number, i);
        PrintArrayPos(digit, 3);
    }
}
