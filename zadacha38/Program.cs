// 41.Выяснить являются ли три числа сторонами треугольника

Random rand = new Random();
int a = rand.Next(1, 50);
Console.WriteLine(a);
int b = rand.Next(1, 50);
Console.WriteLine(b);
int c = rand.Next(1, 50);
Console.WriteLine(c);

if ((a + b > c) && (b + c > a) && (a + c > b))
{
    Console.WriteLine("являются");
}
else Console.WriteLine("не являются");
