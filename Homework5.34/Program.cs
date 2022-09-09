// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

namespace Homework5._34;
class Program
{
     static int[] FillArrRand(int arrSize, int min, int max)
    {
        int[] array = new int[arrSize];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max);
        }
        return array;
    }

    static int GetEvenCount(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i] % 2 == 0) count++;
        }
        return count;
    }
    static void Main(string[] args)
    {
        const int arrSize = 50, min = 100, max = 1000;
        int[] array = FillArrRand(arrSize, min, max);
        int evenCount = GetEvenCount(array);
        System.Console.WriteLine($"В массиве {evenCount} четных чисел");
    }
}
