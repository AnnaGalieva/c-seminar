// Есть два массива info и data.
/*Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
Числа идут друг за другом без разделителей.
Массив info состоит из чисел, которые представляют колличество бит чисел из 
массива data.
Составить массив десятичных представлений чисел массива data с учётом информации 
из массива info.
Пример:входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 } выходные данные:1, 7, 0, 1*/
/*int[] dataOne = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] infoOne = { 2, 3, 3, 1 };
int n = 0;
void PrintNum(int[] data, int[] info)
{
for (int i = 0; i < info.Length; i++)
{
int number = 0;
for (int k = n; k < n + info[i]; k++)
{
number = number + (int)Math.Pow(2, (n + info[i] - k - 1)) * data[k];
}
Console.Write(number + " ");
n = n + info[i];
}
}
PrintNum(dataOne, infoOne);*/

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };
int[] result=new int[info.Length];
int k=0;//счетчик количества цифр в data
Console.WriteLine("Цифры в data в двоичном выражении:");
for (int i = 0; i < info.Length; i++) // разбиваем data на числа в длвочном коде
                                        // на основе количества бит из info
{
for (int j = 0; j < info[i]; j++)
{
Console.Write(data[k+j]+" ");
}
k+=info[i];
Console.Write(";");
}
k=0;
for (int i = 0; i < info.Length; i++)//преобразуем выделенные числа в десятичные
{
for (int j = 0; j < info[i]; j++)
{
result[i]+=data[k+j]*(int) Math.Pow(2,info[i]-1-j);
}
k+=info[i];
}
Console.WriteLine();
Console.WriteLine("Цифры в data в десятичном выражении:");

for (int i = 0; i < result.Length; i++)
{
Console.Write(result[i]+" ");
}

