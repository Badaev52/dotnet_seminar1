string? str1;
string? str2;
string? str3;

int num1, num2, num3;
int max;

Console.Write("Введите число 1: ");
str1 = Console.ReadLine();
Console.WriteLine("Вы ввели число: " + str1);
Console.WriteLine();

Console.Write("Введите число 2: ");
str2 = Console.ReadLine();
Console.WriteLine("Вы ввели число: " + str2);
Console.WriteLine();

Console.Write("Введите число 3: ");
str3 = Console.ReadLine();
Console.WriteLine("Вы ввели число: " + str3);
Console.WriteLine();

num1 = Convert.ToInt32(str1);
num2 = Convert.ToInt32(str2);
num3 = Convert.ToInt32(str3);

max = num1;

if (num2 > max)
    max = num2;
if (num3 > max)
    max = num3;

Console.WriteLine("Максимальное число : " + max);