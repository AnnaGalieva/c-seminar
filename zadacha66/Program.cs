﻿// Задача 71: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
//A(0,n) = n+1
//A(m,0) = A(m-1,1)
//A(m,n) = A(m-1,A(m,n-1))

int F(int m = 3, int n = 2)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return F(m - 1, 1);
    return F(m - 1, F(m, n - 1));
}

    Console.WriteLine(F());
    