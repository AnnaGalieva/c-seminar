// 72.Написать программу возведения числа А в целую стень 

int DegreeOfNumber(int numberA, int numberB)
{
    if (numberB < 1) return 1;
    return numberA * (DegreeOfNumber(numberA, numberB - 1));
}
Console.Write("input numberA: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("input numberB: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine($"Degree Of {numberA} in {numberB}: {DegreeOfNumber(numberA, numberB)}");

