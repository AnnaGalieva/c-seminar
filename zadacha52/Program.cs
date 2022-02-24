// Задача 55: Дан целочисленный массив. 
//Найти среднее арифметическое каждого из столбцов

var array = new int[6, 6];
void PrintArray()
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write(array[m, n] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray()
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 100);
        }

    }
}
void AverageSum()
{
    double result = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            result = result + array[i, j];

        }

        Console.WriteLine($"среднее арифметическое столбца {j} = {result / array.GetLength(0):F1}");
        result = 0;
    }
}
Console.WriteLine();
FillArray();
PrintArray();
AverageSum();
