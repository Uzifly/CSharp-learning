//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
namespace Seminar5;
class Program
{
    static void GetSum (int[] array)
    {
        int posSum = 0, 
        negSum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            posSum += array[i];            
            else
            negSum += array[i];
        }
        System.Console.WriteLine($"\nСумма положительных чисел = {posSum}.\nСумма отрицательных = {negSum}.");
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
        int[] array = FillArray(12, -20, 20);
        PrintArray(array);
        GetSum(array);
    }
}