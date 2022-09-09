/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
namespace Homework5._37;
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

    static int[] GetPair(int[] array)
    {
        int multPairArrSize = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
        int[] multPairArr = new int[multPairArrSize];
        for (int i = 0; i < multPairArrSize; i++)
        {
            multPairArr[i] = array[i];
        }
        for (int i = 0; i < array.Length / 2; i++)
        {
            multPairArr[i] *= array[array.Length - i - 1];
        }
        

        return multPairArr;
    }
    static void Main(string[] args)
    {
        const int arrSize = 8, min = 0, max = 11;
        int[] array = FillArrRand(arrSize, min, max);
        int[] arrayMult = GetPair(array);
        System.Console.WriteLine(String.Join(" ", array));
        System.Console.WriteLine(String.Join(" ", arrayMult));
    }
}