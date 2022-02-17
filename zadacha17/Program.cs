// 23 Показать таблицу квадратов чисел от 1 до N
int N = new Random().Next(1, 19);
Console.WriteLine(N);

for (int i = 0; i <= N; i++)
{
    Console.WriteLine($"{i}*{i}={i*i}");
}