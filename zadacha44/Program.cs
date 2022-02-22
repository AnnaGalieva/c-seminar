// Задача 46: Написать программу масштабирования фигуры
//Для тех, кто ушёл далеко вперёд, — усложнение.
//Сделать так, чтобы:
//1. Вершины фигуры задавались списком (в одну строку). Например: "(0,0) (2,0) (2,2) (0,2)".
//2. Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
//3. В результате были выводились полученные координаты.
//При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

int[,] GetNewScale(int[] a, int[] b, int[] c, int[] d, int k)
{
    int[,] coor = new int[4, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            if (i == j)
            {

                coor[0, j] = a[i] * k;
                coor[1, j] = b[i] * k;
                coor[2, j] = c[i] * k;
                coor[3, j] = d[i] * k;
            }
        }
    }
    return coor;
}

void PrintScale(int[,] arr, char[] point)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{point[i]} ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"({arr[i, j]}, ");
            else Console.WriteLine($"{arr[i, j]})");
        }
    }
}

int k = 2;
int[] pointA = { 0, 0 };
int[] pointB = { 2, 0 };
int[] pointC = { 2, 2 };
int[] pointD = { 0, 2 };
char[] pointName = { 'A', 'B', 'C', 'D' };


Console.WriteLine();
Console.WriteLine(" ");
int[,] newCords = GetNewScale(pointA, pointB, pointC, pointD, k);
PrintScale(newCords, pointName);
Console.WriteLine(" ");



