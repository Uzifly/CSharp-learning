//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

namespace Homework5._38;
class Program
{
    static void Main(string[] args)
    {
        double min = 0, max = 0;
        double[] array = FillArrRand(10, -1000, 1001);
        foreach (var item in array)
        {
            System.Console.Write(" {0:f2}", item);
            if (item < min) min = item;
            if (item > max) max = item;
        }
        System.Console.WriteLine("\nРазница между максимальным и минимальным элементом массива = : {0:f2}", (max - min));
    }

    static double[] FillArrRand(int arrSize, int min, int max)
    {
        double[] array = new double[arrSize];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().NextDouble() + new Random().Next(min, max);
        }
        return array;
    }
}
