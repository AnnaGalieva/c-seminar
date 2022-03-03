// Написать программу показывающие первые N чисел, для которых каждое следующее 
//равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем(3+5=8,8+5=13,13+21)

/*int N = 7;
int a = 3;
int b = 5;
int Metod(int x, int y, int num)
{
    if (num == 1) return x;
    if (num == 2) return y;
    return Metod(x, y, num - 1) + Metod(x, y, num - 2);
}
//Console.WriteLine(Metod(a, b, N));
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(Metod(a, b, i));
}*/
int SumPare(int n, int a, int b)
{
    if (n < 4)
        return (a + b);
    Console.Write(a + b + "");
    return SumPare(n - 1, b, a + b);
}
Console.WriteLine("Введите число1 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число1 2: ");
int num2 = int.Parse(Console.ReadLine());
int n = 10;
Console.Write(num1 + " " + num2 + " ");
Console.Write(SumPare(n, num1, num2));




