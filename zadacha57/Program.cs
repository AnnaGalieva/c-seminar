// 61.Найти произведение двух матриц
int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] matrix2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

Console.WriteLine();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        int result = 0;
        result = matrix1[i, j] * matrix2[i, j];
        Console.Write($"{result} ");
        Console.WriteLine("\n");
    }

}
