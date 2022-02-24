// 62.В двумерном массиве целых чисел. 
//Удалить строку и столбец, на пересечении которых расположен наименьший элемент.


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
int m = 3;
int n = 3;
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int x = 0;
int y = 0;
//мин значение
int min = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            x = i; y = j;
        }
    }
}
int[,] mass = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
for (int i = 0; i < length; i++)
{

}


Console.WriteLine(min);
