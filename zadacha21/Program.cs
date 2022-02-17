// Задача 24: Найти кубы чисел от 1 до N
System.Console.Write("Введите число:   ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
    Console.WriteLine(i * i * i + " ");
