// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
System.Console.Write("Введите день недели:");
int day = int.Parse(Console.ReadLine());
if (day >= 1 && day <= 7) {
    if (day == 6 || day ==7) System.Console.WriteLine("Выходной день");
    else System.Console.WriteLine("Будний день");
}
else System.Console.WriteLine("Не день недели");