//19 Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int x = new Random().Next(-99, 99);
Console.WriteLine(x);
int y = new Random().Next(-99, 99);
Console.WriteLine(y);
if (x == 0 || y == 0)
{
    Console.WriteLine("одна из точек равна нулю");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("точка в первой четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("точка во второй четверти");
}
else if (x < 0 && y > 0)

{
    Console.WriteLine("точка в четвертой четверти");
}
else Console.WriteLine("точка в третьей четверти");