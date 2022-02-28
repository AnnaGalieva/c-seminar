// 68.Показать натуральные числа от M до N, N и M заданы

void PrintNumber(int m, int n)
{
    if (n < m) return;
    PrintNumber(m, n - 1);
    Console.Write(n + " ");
}
Console.Write("input m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("input n: ");
int n = int.Parse(Console.ReadLine());
PrintNumber(m, n);



