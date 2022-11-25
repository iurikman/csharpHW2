Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a>100) {
while (a > 1000)
{
    a = a/10;
}
a = a%10;

Console.WriteLine($"{a}");
}
else Console.WriteLine("3й цифры нет");