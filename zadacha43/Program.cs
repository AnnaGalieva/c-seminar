// Задача 44: Найти точку пересечения двух прямых заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
//x = ( b2 - b1 ) / ( k1 -  k2 )
//y = k1 x + b1. 
double k1 = new Random().Next(0, 100);
Console.WriteLine($"k1 = {k1}");
double k2 = new Random().Next(0, 100);
Console.WriteLine($"k2 = {k2}");
double b1 = new Random().Next(0, 100);
Console.WriteLine($"b1 = {b1}");
double b2 = new Random().Next(0, 1000);
Console.WriteLine($"b2 = {b2}");
Console.WriteLine();
double x = 0;
double y = 0;

x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

Console.WriteLine($"Точка пересечения: ({x} ;{y})");
