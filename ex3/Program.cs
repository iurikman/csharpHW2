Console.WriteLine("Введите число от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());




if (a>0 && a<8) 
{
    if (a>=5) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else Console.WriteLine("Вы ввели неверное число");