// Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

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
int n = 6;
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int index = 0;
int sum = 0;
int result = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    if (i == 0) result = sum;
    else if (sum < result)
    {
        result = sum;
        index = i;
    }
}
Console.WriteLine("строка с наименьшей суммой элементов=" + index);
Console.WriteLine();


