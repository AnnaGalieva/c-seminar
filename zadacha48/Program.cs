// 54.В матрице чисел найти сумму элементов главной диагонали

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
        }

    }
}
Console.WriteLine("Введите кол-во строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int sum = 0;
int size = 0;
if (m > n) size = n;
else size = m;
for (int i = 0; i < size; i++)
{
    sum += array[i, i];
}
Console.WriteLine(sum);
//PrintArray(array);