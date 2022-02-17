// 40.В Указанном массиве вещественных чисел найдите разницу между 
//максимальным и минимальным элементом

int[] array = new int[6];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + " ");
}
int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];

    if (array[i] < min) min = array[i];
}
Console.WriteLine();
Console.WriteLine($"разница между максимальным {max} и минимальным{min} элементом {max - min}");

