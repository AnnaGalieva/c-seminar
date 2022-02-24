// Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.


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
            matr[m, n] = m + n;
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

