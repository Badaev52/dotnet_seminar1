
string? str1;
string? str2;

int num1, num2;

Console.Write("Введите число 1: ");
str1 = Console.ReadLine();
Console.WriteLine("Вы ввели число: " + str1);
Console.WriteLine();

Console.Write("Введите число 2: ");
str2 = Console.ReadLine();
Console.WriteLine("Вы ввели число: " + str2);

Console.WriteLine();

num1 = Convert.ToInt32(str1);
num2 = Convert.ToInt32(str2);

if(num1 > num2)
    Console.WriteLine(num1 + " больше " + num2);
else if(num2 > num1)
    Console.WriteLine(num2 + " больше " + num1);
else
    Console.WriteLine(num1 + " равно " + num2);

