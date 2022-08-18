// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.WriteLine("Enter two numbers:");
int numberA = Convert.ToInt16(Console.ReadLine());
int numberB = Convert.ToInt16(Console.ReadLine());
if (numberA > numberB) {
    System.Console.WriteLine("max = " + numberA);
}
else{
    System.Console.WriteLine("max = " + numberB);
}