// Задача 49: Показать двумерный массив размером m×n, 
//заполненный вещественными числами.

void PrintArray(double[,] matr)
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
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble();
        }

    }
}
Console.WriteLine("Введите кол-во строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);

