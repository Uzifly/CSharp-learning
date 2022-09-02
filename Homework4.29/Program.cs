/*
* Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
* пользователь вводит число элементов в массиве и минимальное, 
* и максимальное значение . надо заполнить массив рандоными данными от минимального до максимального значение .
* И важное уточнениее , делать все в методе который возвращает массив
* 5, 1, 20 -> [1, 2, 5, 7, 19]
* 3, 1, 33 -> [6, 1, 33]
*/

namespace Homework4._29;
class Program
{
    //заполнение массиа
    static int[] FillArrRand(int arrSize, int min, int max)
    {
        int[] array = new int[arrSize];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max);
        }
        return array;
    }

    static int GetValue (string message)
    {
        System.Console.Write(message);
        int val = Convert.ToInt32(Console.ReadLine());
        return val;
    }

    //печать массива
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"{array[i]}, ");
        }
    }

    static void Main(string[] args)
    {
        //константы 
        int arrSize = GetValue("Введите размер массива: ");
        int min = GetValue("Укажите минимальное значение массива: ");
        int max = GetValue("Укажите максимальное значение массива: ");
        int[] array = FillArrRand(arrSize, min, max);
        PrintArray(array);
    }
}