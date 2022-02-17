// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if(a == b*b)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
