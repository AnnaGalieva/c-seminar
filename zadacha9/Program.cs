// Задача 10: Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
if(n >= 100) n /= 10;
int num = n % 10;
Console.WriteLine("вторая цифра" + num);