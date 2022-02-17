// 33.Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
int sum_plus = 0;
int sum_minus = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    if (array[i] > 0)
        sum_plus += array[i];
    else sum_minus += array[i];
}
Console.WriteLine("Сумма положительных элементов:" + sum_plus);
Console.WriteLine("Сумма отрицательных элементов:" + sum_minus);

