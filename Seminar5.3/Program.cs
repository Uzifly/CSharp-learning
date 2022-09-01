// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

namespace Seminar5._3;
class Program
{    
    static int FindEntrance (int[] array, int min, int max)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] >= min && array[i] <= max) 
                count++; 
        return count;
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
        int[] array = FillArray(123, 0, 1000);
        PrintArray(array);
        int count = FindEntrance(array, 10, 99);
        System.Console.WriteLine($"\nЧисло вхождений в массив чисел в диапазоне от 10 до 99 = {count}");
    }
}