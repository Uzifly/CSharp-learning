namespace Seminar_7;
class Program
{
    static void Main(string[] args)
    {
        string[] tasks = new string[] {
            @"Задача 48: Задайте двумерный массив размера m на n, 
            каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
            Выведите полученный массив на экран",
            @"Задача 49: Задайте двумерный массив. 
            Найдите элементы, у которых оба индекса 
            чётные, и замените эти элементы на их квадраты.",
            @"Задача 51: Задайте двумерный массив. 
            Найдите сумму элементов, находящихся на 
            главной диагонали (с индексами (0,0); (1;1) и т.д."
        };
        Selecttask(tasks);
    }
    static void Selecttask(string[] taskDescription)
    {
        System.Console.WriteLine(String.Join("\n", taskDescription));
        System.Console.WriteLine("введите номер задачи:");
        int taskNumber = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        switch (taskNumber)
        {
            case 48:
            Task48();
            break;
            case 49:
            Task49();
            break;            
            case 51:
            Task51();
            break;
            default:
            System.Console.WriteLine("Задача не найдена.");
            break;
        }
    }
    static void Task48()
    {
        System.Console.Write("Укажите размер матрицы:");
        int m = int.Parse(Console.ReadLine());
        int[,] pifagorArray = GetPifagorArray(m);
        PrintArray(pifagorArray);
    }
    static void Task49()
    {
        System.Console.Write("Укажите размер матрицы:");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[,] array = GetRandomValues(n,m);
        PrintArray(array);
        array = GetHonestToSqare(array);
        System.Console.WriteLine();
        PrintArray(array);
    }
    static void Task51()
    {
        System.Console.Write("Укажите размер матрицы:");
        int m = int.Parse(Console.ReadLine());
        int[,] array = GetRandomValues(m, m, min: 0,max: 11);
        PrintArray(array);
        System.Console.WriteLine("Сумма главной диагонали = " + SumMainDiag(array));
    }

    static int[,] GetRandomValues(int n ,int m, int min = -100, int max = 101)
    {
        int[,] array = new int[n,m];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(min, max);
            }
        }
        return array;
    }

    static int SumMainDiag(int[,] array)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i==j) sum += array[i,j];
            }
        }
        return sum;
    }

    static int[,] GetHonestToSqare(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i+=2)
        {
            for (int j = 0; j < array.GetLength(1); j+=2)
            {
                if ((i % 2 == 0) && (j % 2 == 0)) array[i,j] = (int)Math.Pow(array[i,j], 2);
            }
        }
        return array;
    }

    static int[,] GetPifagorArray(int m)
    {
        int[,] pifArr = new int[m,m];
        for (int i = 0; i < pifArr.GetLength(0); i++)
        {
            for (int j = 0; j < pifArr.GetLength(1); j++)
            {
                pifArr[i,j] = i + j;
            }
        }
        return pifArr;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write(" " + array[i,j]);
            }
            System.Console.WriteLine();
        }
    }
}

