// Задача 69: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
//M = 1; N = 4 -> 10
//M = 4; N = 8. -> 30
/*int PrintNumber(int m = 4, int n = 8)
{
    if (m > n) return 1;
    return m + PrintNumber(m + 1, n);
}
Console.Write($"сумма элементов: {PrintNumber()-1}");*/

/*int PrintNumber(int m, int n)
{
    if (n == m) return n;
    return m + PrintNumber(m + 1, n);
}
Console.WriteLine(PrintNumber(4, 8));*/

int PrintNumber(int m = 1, int n = 5)
{
    if (n == m) return n;
    return m + PrintNumber(m + 1, n);
}
Console.WriteLine(PrintNumber());