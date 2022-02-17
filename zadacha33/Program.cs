// 39.Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = new int[5];
// заполняем массив рандомными числами
int[] Random_numbers(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(1, 10);
    return mass;
}
//Выводим массив на печать
void Massive_output(int[] mass)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write(mass[i] + " ");
    Console.WriteLine();
}
/ int count = 0;
Random_numbers(array);
Massive_output(array);

int j = array.Length - 1;
for (int i = 0; i < (array.Length + 1) / 2; i++)
{
    Console.Write(array[i] * array[j] + " ");
    j--;
} /
//функция расчета по заданным парвметрам
//int[]Back_array(int[]mass)
//{
//  int reserv_array=new int[(mass.Length + 1) / 2];
// int j=mass.Lenght-1;
// for (int i = 0; i < reserv_array.Length; i++)
//reserv_array[i] *= mass[j] * mass[i];
//j--;

// return reserv_array;
//}
//Random_numbers(array);
//Massive_output(array);
// Massive_output(Back_array(array));