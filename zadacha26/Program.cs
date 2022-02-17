// 26. Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число   : ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень : ");
int B = int.Parse(Console.ReadLine());
int res = 1;
for (int i = 0; i <= B; i++)
    res = res * A;
Console.WriteLine($"Число {A} в степени {B} = {res}");
