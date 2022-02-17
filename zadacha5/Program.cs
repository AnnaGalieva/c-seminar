// Вычислить является ли число четным.
Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число нечетное");
}