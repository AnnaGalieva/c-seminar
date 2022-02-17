// 30. Показать кубы чисел, заканчивающихся на четную цифру.
int N = new Random().Next(1, 30);
Console.WriteLine($"N = {N}");
int number = 1;
Console.WriteLine("кубы чисел, заканчивающихся на четную цифру");
while (number <= N)
{
    int result = number * number * number;
    if (result % 2 == 0) Console.Write(result + " ");
    number++;
}
Console.WriteLine();