/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
namespace Homework5._36;
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

    static int GetSumEvenPos(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.GetLength(0); i += 2)
        {
            sum += array[i];
        }
        return sum;
    }
    static void Main(string[] args)
    {
        const int arrSize = 50, min = -999, max = 1000;
        int[] array = FillArrRand(arrSize, min, max);
        int evenPosSum = GetSumEvenPos(array);
        System.Console.WriteLine($"Сумма чисел в нечетных позициях равна {evenPosSum}");
    }
}
