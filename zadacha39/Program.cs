// 43.Написать программу преобразования десятичного числа в двоичное.

Console.WriteLine("введите число: ");
int a = int.Parse(Console.ReadLine());
int k;
string result = " ";
while (a > 0)
{
    k = a % 2;//остаток от деления
    result = k + result;//перевернули поменяв местами
    a = a / 2;//деление
}
Console.WriteLine($"Вывод:{result}");


//второй вариант
Console.WriteLine("введите число: ");
int x = int.Parse(Console.ReadLine());
int x1 = x;
int count = 0;
Console.WriteLine($"число {x} в двоичной системе: ");
for (int i = 1; x > 0; i++)//опеределяем количество цифр в двочной системе
{
    x = x / 2;
    count = i;
}
int[] r = new int[count];
for (int i = 1; i < count; i++)//заполняем массив значениями
{
    //if (x1 % 2 == 0)
    r[i] = x1 % 2;
    //else
    //  r[i] = 1;
    x1 = x1 / 2; ;
    //Console.WriteLine(r[1] +" ");//результат наполнения массива
}
Console.WriteLine();
for (int i = count - 1; i >= 0; i--)//выводим в обратном порядке
    Console.Write(r[i] + " ");
Console.WriteLine();





