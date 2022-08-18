Console.WriteLine("Введите два числа:");
int number = Convert.ToInt32(Console.ReadLine());
int squarenumber = Convert.ToInt32(Console.ReadLine());
if (number*number == squarenumber)
    {
        Console.WriteLine("число b является квадратом числа а");
    }
else 
    {
        Console.WriteLine("число b не является квадратом числа а");
    }