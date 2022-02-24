// Задача 53: В двумерном массиве показать позиции числа, 
//заданного пользователем, или указать, что такого элемента нет.


void PrintArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write(matr[m, n] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(1, 100);
        }

    }
}
Console.WriteLine("Введите кол-во строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine("ведите число");
int num = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == num)
        {
            Console.WriteLine($"{num} на позиции[{i},{j}");
            count++;
        }
    }
}
if (count == 0) Console.WriteLine("такого элемента нет " + num);
Console.WriteLine();
FillArray(array);
PrintArray(array);





