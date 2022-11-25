string? str;
int num;

Console.Write("Введите число: ");
str = Console.ReadLine();
Console.WriteLine();

num = Convert.ToInt32(str);

if ( num == 0)
    Console.WriteLine("Число " + num + " равно нулю");
else if ((num % 2) == 0)
    Console.WriteLine("Число " + num + " является четным");
else
    Console.WriteLine("Число " + num + " не является четным");