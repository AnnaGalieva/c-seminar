// 29 Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.WriteLine());
int Factor(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++) 
    {
        result *= i;
    }
    return result;
}
Console.WriteLine(Factor(number));