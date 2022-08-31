namespace Seminar4._1;
class Program
{

    static void Main(string[] args)
    {
        //константы 
        const int arrSize = 8;
        const int min = 0;
        const int max = 2; //генерация до указанного значения

        int[] array = new int[arrSize];

        FillArrRand(array, min, max);
        PrintArray(array);

        //заполнение массиа
        void FillArrRand(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max);
            }
        }

        //печать массива

        void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write($"{array[i]}, ");
            }
        }
    }
}
