﻿// 70.Найти сумму цифр числа
int SumDigits(int number)
{
    if (number < 1) return 0;
    return SumDigits(number / 10) + number % 10;
}
Console.Write("input number: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"SumDigits: {SumDigits(number)}");
