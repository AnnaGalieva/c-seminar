// 60. Составить частотный словарь элементов двумерного массива


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
int m = 6;
int n = 6;
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[,] dictionary = new int[m * n, 2];
int k = 0;
bool exist = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        exist = false;
        for (int r = 0; r < k; r++)
        {
            if (dictionary[r, 0] == array[i, j])
            {
                exist = true;
                dictionary[r, 1]++;
                break;

            }
        }
        if (exist == false)
        {
            dictionary[k, 0] = array[i, j];
            dictionary[k, 1]++;
            k++;
        }
    }

}
for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < dictionary.GetLength(1); j++)
        {
            Console.Write(dictionary[i, j] + " ");
        }
        Console.WriteLine();
    }


