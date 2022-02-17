// Задача 20: Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти от 1 до 4");
int N = int.Parse(Console.ReadLine());

if (N == 1) Console.WriteLine("x > 0, y > 0");
else if (N == 2) Console.WriteLine("x < 0, y > 0");
else if (N == 3) Console.WriteLine("x < 0, y < 0");
else if (N == 4) Console.WriteLine("x > 0, y < 0");
else Console.WriteLine("Такой четверти нет");

