// 58.Написать программу, которая в двумерном массиве заменяет строки на столбцы или 
//сообщить, что это невозможно (в случае, если матрица не квадратная).


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[j, i] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }

    }
}
int m = 4;
int n = 4;
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
/*for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        Console.Write(array[j, i] + " ");
    }
    Console.WriteLine();
}*/
int[,] mass = new int[array.GetLength(0), array.GetLength(1)];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = array[j, i];
    }

}
Console.WriteLine();
PrintArray(mass);
Console.WriteLine();


