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