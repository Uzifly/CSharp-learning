// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

namespace Homework3._21;
class Program
{
    static int[] GetPoints(String message)
    {
        int[] array = new int[3];
        System.Console.WriteLine(message);
        foreach (int i in array)
        {
            array[i] = Try(System.Console.Read());
        }
            //array[i] = Convert.ToInt16(System.Console.Read());
        return array;
    }

    static void Main(string[] args)
    {
        int[] pointA = GetPoints("Введите координаты точки А");
        Console.WriteLine("Hello, World!");
    }
}
