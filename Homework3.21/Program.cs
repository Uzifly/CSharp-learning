// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

namespace Homework3._21;
class Program
{
    static int[] Get3DPoints(String message)
    {
        int[] array = new int[3];
        System.Console.WriteLine(message);
        for(int i = 0; i < array.Length; i++)
            array[i] = Convert.ToInt32(System.Console.ReadLine());
        return array;
    }

    static double Get3dPointDistance(int[] pA, int[] pB)
    {
        double dist = 0;
        if (pA.Length == pB.Length)
        {
            for (int i = 0; i < pA.Length; i++)
                dist += Math.Pow((pA[i] - pB[i]), 2);
            dist = Math.Sqrt(dist);
        }
        return dist;
    }

    static void Main(string[] args)
    {
        int[] pointA = Get3DPoints("Введите координаты точки А");
        int[] pointB = Get3DPoints("Введите координаты точки B");
        double distance = Get3dPointDistance(pointA, pointB);
        System.Console.WriteLine($"расстояние между точками = {distance}");
    }
}
