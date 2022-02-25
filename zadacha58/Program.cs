// Задача 57: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }

    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 3;
int n = 3;
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int minPosition = j;
        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[i, k] > array[i, minPosition]) minPosition = k;
        }
        int tmp = array[i, j];
        array[i, j] = array[i, minPosition];
        array[i, minPosition] = tmp;
    }
}
PrintArray(array);




