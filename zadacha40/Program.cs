// 45.Показать числа Фибоначчи.
int num = 10;
int f1 = 1;
int f2 = 1;
int result;
for (int i = 0; i < num; i++)
{
    result = f1 + f2;
    Console.Write(result + " ");

    f1 = f2;
    f2 = result;
}
//другое решение
int a = 0;
int b = 1;
int count = 10;
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{a}, {b}, ");
    a = a + b;
    b = b + a;
}
