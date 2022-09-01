// Общее обсуждение решения
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

namespace Seminar5._1;
class Program
{
    static int[] ReverseArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] *= (-1);
        return array;
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
        int[] array = FillArray(20, -99, 100);
        PrintArray(array);
        array = ReverseArray(array);
        System.Console.WriteLine();
        PrintArray(array);
    }
}