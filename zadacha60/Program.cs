//66.Показать натуральные числа от 1 до N, N задано

/*void PrintNumber(int n)
{
    if (n < 1) return;
    PrintNumber(n-1);
    Console.Write(n + " ");
}
PrintNumber(10);*/

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
string Print(int k)
{
    if (k < 1) return string.Empty;
    return Print(k - 1) + " " + k.ToString();
}
Console.WriteLine(Print(n));



