string? str;
int num;

Console.Write("Введите число: ");
str = Console.ReadLine();
Console.WriteLine();

num = Convert.ToInt32(str);

int count = 1;

while (count <= num){
    int n = count;
    if ((n % 2) == 0){
        Console.Write(n + ", ");
    }
    count++;
}