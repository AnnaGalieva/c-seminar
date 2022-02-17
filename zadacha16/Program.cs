// 21Программа проверяет пятизначное число на палиндромом.
int a = new Random().Next(10000, 99999);
Console.WriteLine(a);

if (a / 100000 == a % 10 && a / 10000 % 10 == a % 100 / 10)
{
    Console.WriteLine("число палиндром");
}
else Console.WriteLine("Число не палиндром");