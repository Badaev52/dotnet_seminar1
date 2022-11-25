
string? str1;
string? str2;

int num1, num2;

Console.Write("Введите число 1: ");
str1 = Console.ReadLine();
Console.WriteLine("Вы ввели число: " + str1);
Console.WriteLine();

Console.Write("Введите число 2: ");
str2 = Console.ReadLine();
Console.WriteLine("Вы ввели число: " + str1);

Console.WriteLine();

num1 = Convert.ToInt32(str1);
num2 = Convert.ToInt32(str2);

if(num1 > num2)
    Console.WriteLine("Число 1: " + num1 + " больше " + " Числа 2: " + num2);
else if(num2 > num1)
    Console.WriteLine("Число 2: " + num2 + " больше " + " Числа 1: " + num1);
else
    Console.WriteLine("Число 1: " + num1 + " равно " + " Числу 2: " + num2);

