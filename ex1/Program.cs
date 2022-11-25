Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());

if (a>99 && a<1000) Console.WriteLine($"{a = a/10%10}");
else Console.WriteLine("Вы ввели не трехзначное число!");
