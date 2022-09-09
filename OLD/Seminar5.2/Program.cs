// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
namespace Seminar5._2;
class Program
{    
    static bool FindValue (int[] array, int value)
    {
        bool isFind = false;
        for (int i = 0; i < array.Length; i++)
            if (array[i] == value) 
                isFind = true; 
        return isFind;
    }

    static int[] FillArray (int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
            array[i] = new Random().Next(min, max);
        return array;
    }

    static void PrintArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            System.Console.Write($"{array[i]} ");
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Введите искомое число");
        int value = Convert.ToInt32(System.Console.ReadLine());
        int[] array = FillArray(40, -99, 100);
        PrintArray(array);
        bool valueIsFind = FindValue(array, value);
        System.Console.WriteLine();
        if (valueIsFind)
            System.Console.WriteLine("Число найдено");
        else
            System.Console.WriteLine("Число не найдено");

    }
}