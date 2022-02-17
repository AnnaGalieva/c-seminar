// Задача 14: Найти третью цифру числа или сообщить, что её нет.

int Number = new Random().Next(1, 1500);
Console.WriteLine($"Дано число: {Number}");
if (Number>100)
{
    while (Number>1000)
{
Number= Number/10;
}
System.Console.WriteLine(Number%10);
}
else Console.WriteLine("Третьей цифры нет");
