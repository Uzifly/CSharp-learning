﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt16(Console.ReadLine());
if (number%2 > 0) System.Console.WriteLine("нечет");
else System.Console.WriteLine("чет");