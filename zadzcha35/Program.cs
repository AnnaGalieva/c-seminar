// 36.Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать колличество нечетных\четных чисел

int[] array = new int[13];
int odd = 0;     //нечетные
int even = 0;    //четные
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0)
    {
        even++;
    }
    else odd++;
}
Console.WriteLine("Колличество четных чисел=" + even);
Console.WriteLine("Колличество нечетных чисел=" + odd);